using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AuditServices.Constants.MessageConstants;
using AuditServices.Constants.PocoConstants;
using AuditServices.DAL;
using AuditServices.Models.Entities;
using AuditServices.Utilities.FileUtilities;
using AuditServices.Utilities.UserUtilities;
using AuditServices.ViewModels.AdminVMs.UserVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = DefaultRoleConstants.Admin+ "," + DefaultRoleConstants.Moderator)]
    public class UserController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        public UserController(AppDbContext dbContext, UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityRole adminRole = await _roleManager.FindByNameAsync(DefaultRoleConstants.Admin);
            // we need this to exclude admin user because we won't show admin user in the user list
            IdentityUserRole<string> adminAndRole = await _dbContext.UserRoles
             .Where(ur => ur.RoleId == adminRole.Id).FirstOrDefaultAsync();
            ICollection<User> users = await _userManager.Users
                .Where(u => !u.IsDeleted && u.Id != adminAndRole.UserId && u.Id != currentUserId)
                .ToListAsync();
            UserIndexVM model = new();
            foreach (User user in users)
            {
                model.UsersRoles.Add(new UserAndRole
                {
                    User = user,
                    RolesNames = await _userManager.GetRolesAsync(user),
                });
            }
            return View(model);
        }
        public async Task<JsonResult> Search(string userName)
        {
            IdentityRole adminRole = await _roleManager.Roles
                    .FirstOrDefaultAsync(r => r.Name == DefaultRoleConstants.Admin);
            string adminId = (await _dbContext.UserRoles
                .FirstOrDefaultAsync(u => u.RoleId == adminRole.Id)).UserId;
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserIndexVM model = new();
            if (String.IsNullOrEmpty(userName))
            {
                ICollection<User> Allusers = await _userManager.Users
                    .Where(u => !u.IsDeleted
                    && u.Id != currentUserId && u.Id != adminId).ToListAsync();
                foreach (User user in Allusers)
                {
                    model.UsersRoles.Add(new UserAndRole
                    {
                        User = user,
                        RolesNames = await _userManager.GetRolesAsync(user),
                    });
                }
                return Json(model);
            }
            ICollection<User> users = await _userManager.Users.Where
                (u => !u.IsDeleted && u.Id != currentUserId && u.Id != adminId &&
                u.UserName.StartsWith(userName)).ToListAsync();
            foreach (User user in users)
            {
                model.UsersRoles.Add(new UserAndRole
                {
                    User = user,
                    RolesNames = await _userManager.GetRolesAsync(user),
                });
            }
            return Json(model);
        }
        public async Task<IActionResult> ChangePassword(string id)
        {
            User user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
            if (user == null) return NotFound();
            return View(new UserChangePasswordVM{ Id = user.Id, });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(UserChangePasswordVM model, string id)
        {
            if (model.Id != id) return BadRequest();
            if (!ModelState.IsValid) return View(model);
            User user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
            if (user == null) return NotFound();
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager
                .CheckPasswordSignInAsync(user, model.NewPassword, false);
            if (signInResult.Succeeded)
            {
                ModelState.AddModelError(nameof(UserChangePasswordVM.NewPassword), "" +
                    "The new password cannot be the same as the old password!");
                return View(model);
            }
            IdentityResult result = await _userManager
                .ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
            await _userManager.UpdateSecurityStampAsync(user);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserCreateVM model)
        {
            if (!ModelState.IsValid) return View();
            if (_dbContext.Users.Any(u => !u.IsDeleted && u.Email == model.Email))
            {
                ModelState.AddModelError(nameof(UserCreateVM.Email),
                     "Bu email-nan artiq bashqa bir istifadeci databazada var. " +
                    "Xaish edirik bashqa email daxil edin");
                return View();
            }
            if (!model.Image.IsImg())
            {
                ModelState.AddModelError(nameof(UserCreateVM.Image),
                  FileMessageConstants.ImageContentError);
                return View();
            }
            if (!model.Image.CheckSizeForMg())
            {
                ModelState.AddModelError(nameof(UserCreateVM.Image),
                  FileMessageConstants.MgSizeError);
                return View();
            }
            Guid guid = Guid.NewGuid();
            await model.Image.CreateAsync(guid,FileNameConstants.Image);
            User user = new()
            {
                Email = model.Email,
                UserName = model.UserName,
                Image=guid+model.Image.FileName
            };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(user, DefaultRoleConstants.User);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(string id)
        {
            User user = await _userManager.Users
                .Include(u => u.Comments).ThenInclude(c=>c.Blog)
            .FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
            if (user == null) return NotFound();
            return View(new UserDetailVM
            {
                User = user,
                Blogs = await _dbContext.Blogs.Where(r => !r.IsDeleted && r.User == user).ToListAsync(),
            });
        }
        public async Task<IActionResult> Update(string id)
        {
            User user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
            if (user == null) return NotFound();
            return View(new UserUpdateVM
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
            });
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateVM model)
        {
            User user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.Id == model.Id && !u.IsDeleted);
            if (user == null) return NotFound();
            if (!ModelState.IsValid) return View(model);
            if (_userManager.Users.Any(u => u.Email == model.Email && u.Id != user.Id))
            {
                ModelState.AddModelError(nameof(UserUpdateVM.Email),
                    "Bu email-nan artiq bashqa bir istifadeci databazada var. " +
                    "Xaish edirik bashqa email daxil edin");
                return View(model);
            }
            if (model.Image != null)
            {
                FileDeleter.Delete(FileNameConstants.Image, user.Image);
                if (!model.Image.IsImg())
                {
                    ModelState.AddModelError(nameof(UserUpdateVM.Image),
                      FileMessageConstants.ImageContentError);
                    return View();
                }
                if (!model.Image.CheckSizeForMg())
                {
                    ModelState.AddModelError(nameof(UserUpdateVM.Image),
                      FileMessageConstants.MgSizeError);
                    return View();
                }
                Guid guid = Guid.NewGuid();
                await model.Image.CreateAsync(guid, FileNameConstants.Image);
                user.Image = guid + model.Image.FileName;
            }
            user.Email = model.Email;
            user.UserName = model.UserName;
            IdentityResult result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<string> Delete(string id)
        {
            User user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
            if (user == null) return "Not Found";
            user.IsDeleted = true;
            user.DeletedDate = DateTime.Now;
            await _userManager.UpdateAsync(user);
            await _dbContext.SaveChangesAsync();
            return "Success";
        }
        public async Task<bool> Block(string id)
        {
            User user = await _userManager.Users.FirstOrDefaultAsync(u => !u.IsDeleted && u.Id == id);
            if (user == null) return false;
            user.LockoutEnabled = true;
            user.LockoutEnd = DateTimeOffset.MaxValue;
            user.IsBlocked = true;
            await _userManager.UpdateAsync(user);
            await _userManager.UpdateSecurityStampAsync(user);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UnBlock(string id)
        {
            User user = await _userManager.Users.FirstOrDefaultAsync(u => !u.IsDeleted && u.Id == id);
            if (user == null) return false;
            user.LockoutEnd = DateTimeOffset.Now;
            user.IsBlocked = false;
            await _userManager.UpdateAsync(user);
            await _userManager.UpdateSecurityStampAsync(user);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
