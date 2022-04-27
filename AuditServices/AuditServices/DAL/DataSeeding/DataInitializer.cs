using System.Linq;
using AuditServices.Models.Entities;
using AuditServices.Utilities.DefaultGenerators.DefaultEntityGenerators;
using AuditServices.Utilities.DefaultGenerators.DefaultPageGenerators;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AuditServices.DAL.DataSeeding
{
    public static class DataInitializer
    {
        public async static void Seed(this IApplicationBuilder builder)
        {
            using IServiceScope scope = builder.ApplicationServices.CreateScope();
            AppDbContext context = scope.ServiceProvider
                .GetRequiredService<AppDbContext>();
            RoleManager<IdentityRole> roleManager = scope.ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();
            UserManager<User> userManager = scope.ServiceProvider
                .GetRequiredService<UserManager<User>>();
            context.Database.Migrate();
            if (!context.Roles.Any())
            {
                await RoleGenerator.GenerateDefaultRolesAsync(roleManager);
                await context.SaveChangesAsync();
            }
            if (!context.Users.Any())
            {
                await UserGenerator.GenerateDefaultUsersAsnyc(userManager);
                await context.SaveChangesAsync();
            }
            if (!context.Blogs.Any())
            {
                await BlogsGenerator.GenerateBlogsAsync(context, userManager);
            }
            if (!context.HomePageTrendingSections.Any())
            {
                await HomePageTrendingSectionGenerator
                    .GenerateHomePageTrendingSectionAsync(context);
            }
            if (!context.HomePageTrendingSectionParts.Any())
            {
                await HomePageTrendingSectionPartGenerator
                    .GenerateHomePageTrendingSectionPartsAsync(context);
            }
            if (!context.HomePageCards.Any())
            {
                await HomePageCardGenerator.GenerateHomePageCardsAsync(context);
            }
            if (!context.Footers.Any())
            {
                await FooterGenerator.GenerateFooterAsync(context);
            }
            if (!context.FooterParts.Any())
            {
                await FooterPartsGenerator.GenerateFooterPartsAsync(context);
            }
            if (!context.FooterPartLinks.Any())
            {
                await FooterPartsLinksGenerator.GenerateFooterPartsLinksAsync(context);
            }
            await context.SaveChangesAsync();
        }
    }
}
