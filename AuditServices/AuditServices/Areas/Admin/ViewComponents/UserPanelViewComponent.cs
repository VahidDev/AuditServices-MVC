using System.Threading.Tasks;
using AuditServices.Models.Entities;
using AuditServices.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuditServices.Areas.Admin.ViewComponents
{
    public class UserPanelViewComponent:ViewComponent
    {
        private readonly UserManager<User> _userManager;
        public UserPanelViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string image = "";
            if (User.Identity.IsAuthenticated)
            {
                image = (await _userManager.FindByNameAsync(User.Identity.Name)).Image;
            }
            return View(new HeaderVM
            {
                Image = image
            });
        }
    }
}
