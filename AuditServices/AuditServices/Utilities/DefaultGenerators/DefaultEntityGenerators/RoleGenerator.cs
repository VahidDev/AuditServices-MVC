using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace AuditServices.Utilities.DefaultGenerators.DefaultEntityGenerators
{
    public static class RoleGenerator
    {
          public static async Task GenerateDefaultRolesAsync
            (this RoleManager<IdentityRole> roleManager)
    {
        await roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
        await roleManager.CreateAsync(new IdentityRole { Name = "Moderator" });
        await roleManager.CreateAsync(new IdentityRole { Name = "User" });
        }
    }
}
