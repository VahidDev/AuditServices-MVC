using System.Collections.Generic;
using System.Threading.Tasks;
using AuditServices.DAL;
using AuditServices.Models.Pages;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.Utilities.DefaultGenerators.DefaultPageGenerators
{
    public static class FooterPartsLinksGenerator
    {
        public static async Task GenerateFooterPartsLinksAsync(AppDbContext context)
        {
            FooterPart connectPart = await context.FooterParts
                .FirstOrDefaultAsync(fp=>fp.Title== "Bağlan");
            FooterPart aboutPart = await context.FooterParts
                .FirstOrDefaultAsync(fp => fp.Title == "Haqqımızda");
            FooterPart legalPart = await context.FooterParts
                .FirstOrDefaultAsync(fp => fp.Title == "Legal");
            await context.FooterPartLinks.AddRangeAsync(new List<FooterPartLink> { 
                new FooterPartLink{
                    Text="Bizim komandamızla tanış ol",
                    FooterPart=connectPart,
                    Link="https://localhost:44316/Team"
                },
                new FooterPartLink{
                    Text="Bizimlə əlaqə qur",
                    FooterPart=connectPart,
                    Link="https://localhost:44316/Contact"
                },
                new FooterPartLink{
                    Text="Haqqımızda",
                    FooterPart=aboutPart,
                    Link="https://localhost:44316/About"
                },
                new FooterPartLink{
                    Text="Karyeralar",
                    FooterPart=aboutPart,
                    Link="#"
                },
                new FooterPartLink{
                    Text="Digər",
                    FooterPart=aboutPart,
                    Link="#"

                },
                new FooterPartLink{
                    Text="Privacy",
                    FooterPart=legalPart,
                    Link="#"
                },
                new FooterPartLink{
                    Text="Cookie policy",
                    FooterPart=legalPart,
                    Link="#"
                },
                new FooterPartLink{
                    Text="Disclaimer",
                    FooterPart=legalPart,
                    Link="#"
                },
            });
            context.FooterParts.UpdateRange(new List<FooterPart> 
            { connectPart,aboutPart,legalPart});
            await context.SaveChangesAsync();
        }
    }
}
