using System.Collections.Generic;
using System.Threading.Tasks;
using AuditServices.DAL;
using AuditServices.Models.Pages;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.Utilities.DefaultGenerators.DefaultPageGenerators
{
    public static class FooterPartsGenerator
    {
        public static async Task GenerateFooterPartsAsync(AppDbContext context)
        {
            Footer footer = await context.Footers.FirstOrDefaultAsync();
            await context.FooterParts.AddRangeAsync(new List<FooterPart> {
                new FooterPart{
                    Title="Bağlan",
                    Order=1,
                    Footer=footer
                },
                new FooterPart{
                    Title="Haqqımızda",
                    Order=2,
                    Footer=footer
                },
                new FooterPart{
                    Title="Legal",
                    Order=3,
                    Footer=footer
                },
            });
            await context.SaveChangesAsync();
        }
    }
}
