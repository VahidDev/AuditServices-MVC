using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditServices.Constants.PocoConstants;
using AuditServices.DAL;
using AuditServices.Models.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = DefaultRoleConstants.Admin + "," + DefaultRoleConstants.Moderator)]
    public class CommentController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public CommentController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<string> Delete(int id)
        {
            Comment comment = await _context.Comments
                .FirstOrDefaultAsync(b => b.Id == id && !b.IsDeleted);
            if (comment == null) return "Not Found";
            comment.IsDeleted = true;
            comment.DeletedDate = DateTime.Now;
            _context.Comments.Update(comment);
            await _context.SaveChangesAsync();
            return "Success";
        }
    }
}
