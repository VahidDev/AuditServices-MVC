using System;
using System.Linq;
using System.Threading.Tasks;
using AuditServices.Constants.MessageConstants;
using AuditServices.DAL;
using AuditServices.Models.Entities;
using AuditServices.Utilities.FileUtilities;
using AuditServices.ViewModels.AccountVMs;
using AuditServices.ViewModels.AdminVMs.UserVMs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly AppDbContext _context;

        public AccountController
            (UserManager<User> userManager, SignInManager<User> signInManager
            ,AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            User user = await _userManager.Users
                .Include(u=>u.Blogs.Where(b=>!b.IsDeleted))
                .FirstOrDefaultAsync(u=>u.UserName==User.Identity.Name);
            
            return View(new AccountIndexVM { 
            Blogs=user.Blogs,
            UserName=user.UserName,
            Email=user.Email,
            Image=user.Image
            });
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AccountLoginRegisterVM accModel)
        {
            AccountLoginVM model = accModel.AccountLoginViewModel;
            if (!ModelState.IsValid) return View();
            User user = await _userManager.Users
                .FirstOrDefaultAsync(u => u.UserName == model.UserName);
            if (user == null)
            {
                ModelState.AddModelError("AccountLoginViewModel.UserName", "Bele bir istifadechi yoxdur");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult =await  _signInManager
                .CheckPasswordSignInAsync(user, accModel.AccountLoginViewModel.Password, false);
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("AccountLoginViewModel.Password", "Şifrə yanlışdır");
                return View();
            }
            if (user.IsBlocked)
            {
                ModelState.AddModelError("", "Bu istifadeci bloklanibdir");
                return View();
            }
            await _signInManager.SignInAsync(user, false);
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AccountLoginRegisterVM accModel)
        {
            AccountRegisterVM model = accModel.AccountRegisterViewModel;
            if (!ModelState.IsValid)
            {
                model.Message = "false";
                return View(nameof(AccountController.Login),accModel);
            }
            User user =await _userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                ModelState.AddModelError("",
                    "Bu istifadəçi adı başqası tərəfindən işlədilir");
                model.Message = "false";
                return View(nameof(AccountController.Login), accModel);
            }
            if (!model.Image.IsImg())
            {
                ModelState.AddModelError(nameof(AccountRegisterVM.Image),
                   FileMessageConstants.ImageContentError);
                model.Message = "false";
                return View(nameof(AccountController.Login), accModel);
            }
            if (!model.Image.CheckSizeForMg())
            {
                ModelState.AddModelError(nameof(AccountRegisterVM.Image),
                    FileMessageConstants.MgSizeError);
                model.Message = "false";
                return View(nameof(AccountController.Login), accModel);
            }
            Guid guid = Guid.NewGuid();
            await model.Image.CreateAsync(guid,FileNameConstants.Image);
            User newUser = new()
            {
                Email = model.Email,
                UserName = model.UserName,
                Image=guid+model.Image.FileName
            };
            IdentityResult result = await _userManager.CreateAsync(newUser, model.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                model.Message = "false";
                return View(nameof(AccountController.Login), accModel);
            }
            await _userManager.AddToRoleAsync(newUser, "User");
            await _signInManager.SignInAsync(newUser, false);
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        
        [HttpGet]
        public async Task<IActionResult> UpdateProfilePicture()
        {
            return View(new AccountUpdateProfilePictureVM {
                CurrentImage = (await _userManager.FindByNameAsync(User.Identity.Name)).Image
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateProfilePicture(AccountUpdateProfilePictureVM model)
        {
            try
            {
                if (!ModelState.IsValid) return View(model);
                User user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (user == null) return NotFound();
                if (!model.NewImage.IsImg())
                {
                    ModelState.AddModelError(nameof(AccountUpdateProfilePictureVM.NewImage),
                       FileMessageConstants.ImageContentError);
                    return View(model);
                }
                if (!model.NewImage.CheckSizeForMg())
                {
                    ModelState.AddModelError(nameof(AccountUpdateProfilePictureVM.NewImage),
                        FileMessageConstants.MgSizeError);
                    return View(model);
                }
                FileDeleter.Delete(FileNameConstants.Image, user.Image);
                Guid guid = Guid.NewGuid();
                await model.NewImage.CreateAsync(guid, FileNameConstants.Image);
                user.Image = guid + model.NewImage.FileName;
                await _userManager.UpdateAsync(user);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Index));
            }
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(UserChangePasswordVM model)
        {
            if (!ModelState.IsValid) return View();
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager
                 .CheckPasswordSignInAsync(user, model.OldPassword, false);
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError(nameof(UserChangePasswordVM.OldPassword),
                    "Köhnə şifrə səhvdir");
                return View();
            }
            if((await _userManager.CheckPasswordAsync
                (user, model.NewPassword)))
            {
                ModelState.AddModelError(nameof(UserChangePasswordVM.OldPassword),
                    "Yeni şifrə köhnə şifrədən fərqlənməlidir!");
                return View();
            }
            IdentityResult changePasswordResult =await _userManager
                .ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                foreach (IdentityError error in changePasswordResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            return RedirectToAction(nameof(Login));
        }
    }
}
