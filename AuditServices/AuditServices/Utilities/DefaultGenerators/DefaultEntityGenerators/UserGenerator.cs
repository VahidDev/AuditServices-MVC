using System.Threading.Tasks;
using AuditServices.Constants.PocoConstants;
using AuditServices.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace AuditServices.Utilities.DefaultGenerators.DefaultEntityGenerators
{
    public static class UserGenerator
    {
        public static async Task GenerateDefaultUsersAsnyc(this UserManager<User> userManager)
        {
            User adminUser = new()
            {
                UserName = DefaultUserConstants.AdminUserName,
                Email = DefaultUserConstants.AdminEmail,
                LockoutEnabled = false,
                Image= "cvPic.jpg"
            };
            await userManager.CreateAsync(adminUser, DefaultUserConstants.AdminPassword);
            await userManager.AddToRoleAsync(adminUser, "Admin");

            User moderatorUser = new()
            {
                UserName = DefaultUserConstants.ModeratorUserName,
                Email = DefaultUserConstants.ModeratorEmail,
                Image= "cvPic.jpg"
            };
            await userManager.CreateAsync(moderatorUser, DefaultUserConstants.ModeratorPassword);
            await userManager.AddToRoleAsync(moderatorUser, "Moderator");

            User vahidUser = new()
            {
                UserName = "vahiduser",
                Email = "vahiduser@gamil.com",
                Image= "cvPic.jpg"
            };
            await userManager.CreateAsync(vahidUser, "vahid123");
            await userManager.AddToRoleAsync(vahidUser, "User");


            User nurlanUser = new()
            {
                UserName = "nurlanUser",
                Email = "nurlanUser@gamil.com",
                Image= "nurlan.jpg"
            };
            await userManager.CreateAsync(nurlanUser, "nurlan123");
            await userManager.AddToRoleAsync(nurlanUser, "User");
        }
    }
}
