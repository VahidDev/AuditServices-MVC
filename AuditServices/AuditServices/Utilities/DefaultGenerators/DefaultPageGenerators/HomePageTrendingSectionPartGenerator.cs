using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuditServices.DAL;
using AuditServices.Models.Pages;

namespace AuditServices.Utilities.DefaultGenerators.DefaultPageGenerators
{
    public static class HomePageTrendingSectionPartGenerator
    {
        public async static Task GenerateHomePageTrendingSectionPartsAsync
            (AppDbContext context)
        {
            HomePageTrendingSection section = context.HomePageTrendingSections
                .FirstOrDefault();
            await context.HomePageTrendingSectionParts
                .AddRangeAsync(new List<HomePageTrendingSectionPart> { 
                    new HomePageTrendingSectionPart
                    {   
                        TrendingSection=section,
                        Title= "IFRS 16",
                        Content= "Understanding the discount rate",
                    },
                    new HomePageTrendingSectionPart
                    {
                        TrendingSection=section,
                        Title= "International financial reporting ...",
                        Content= "COVID 19: Debt modifications",
                    },
                    new HomePageTrendingSectionPart
                    {
                        TrendingSection=section,
                        Title= "International financial reporting ...",
                        Content= "IAS 36 - Identifying cash-generating unit",
                    },
                    new HomePageTrendingSectionPart
                    {
                        TrendingSection=section,
                        Title= "International financial reporting ...",
                        Content= "COVID 19: Government grants",
                    },
                    new HomePageTrendingSectionPart
                    {
                        TrendingSection=section,
                        Title= "IFRS 3",
                        Content= "The acquisition method at a glance",
                    },
                });
            await context.SaveChangesAsync();
        }
    }
}
