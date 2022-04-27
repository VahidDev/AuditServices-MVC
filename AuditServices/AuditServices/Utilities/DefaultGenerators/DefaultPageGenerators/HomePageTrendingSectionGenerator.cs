using System.Threading.Tasks;
using AuditServices.DAL;
using AuditServices.Models.Pages;

namespace AuditServices.Utilities.DefaultGenerators.DefaultPageGenerators
{
    public static class HomePageTrendingSectionGenerator
    {
        public async static Task GenerateHomePageTrendingSectionAsync
            (AppDbContext context)
        {
            await context.HomePageTrendingSections
                .AddAsync(new HomePageTrendingSection { 
                    Title= "What is trending?",
                    Tag= "IFRS",
                    Description= "Insights into IFRS 16"
                });
            await context.SaveChangesAsync();
        }
    }
}
