using System.Collections.Generic;
using System.Threading.Tasks;
using AuditServices.DAL;
using AuditServices.Models.Pages;

namespace AuditServices.Utilities.DefaultGenerators.DefaultPageGenerators
{
    public static class HomePageCardGenerator
    {
        public static async Task GenerateHomePageCardsAsync
            (AppDbContext context)
        {
            await context.HomePageCards.AddRangeAsync(new List<HomePageCard> { 
                new HomePageCard{ 
                    Tag="BUSINESS RESILENCE",
                    Title="Returning your business",
                    Description="Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quis, temporibus?",
                    Image="client-behaviour-300x300.jpg",
                    Order=1,
                },
                new HomePageCard{
                    Tag="BUSINESS RESILENCE",
                    Title="Returning your business",
                    Description="Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quis, temporibus?",
                    Image="card-2.jpg",
                    Order=2,
                },
                new HomePageCard{
                    Tag="BUSINESS RESILENCE",
                    Title="Returning your business",
                    Description="Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quis, temporibus?",
                    Image="card-3.jpg",
                    Order=3,
                },
                new HomePageCard{
                    Tag="BUSINESS RESILENCE",
                    Title="Returning your business",
                    Description="Lorem ipsum dolor sit amet consectetur, adipisicing elit. Quis, temporibus?",
                    Image="card-4.jpg",
                    Order=4,
                }
            });
            await context.SaveChangesAsync();
        }
    }
}
