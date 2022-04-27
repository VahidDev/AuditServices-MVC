using System;
using System.Threading.Tasks;
using AuditServices.DAL;
using AuditServices.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Controllers
{
    [Authorize]
    public class CommentController:Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public CommentController
            (AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpPost]
        public async Task<bool> Create([FromQuery]string text,[FromQuery]int id)
        {
            try
            {
                Blog blog = await _context.Blogs.FindAsync(id);
                if (blog == null) return false;
                if (string.IsNullOrEmpty(text.Trim())) return false;
                blog.CommentsCount += 1;
                await _context.Comments.AddAsync(new Comment
                {
                    Blog = blog,
                    User = await _userManager.FindByNameAsync(User.Identity.Name),
                    Text = text
                });
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
