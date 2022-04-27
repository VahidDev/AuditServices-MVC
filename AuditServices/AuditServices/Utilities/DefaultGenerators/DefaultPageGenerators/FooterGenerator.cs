using System.Threading.Tasks;
using AuditServices.DAL;
using AuditServices.Models.Pages;

namespace AuditServices.Utilities.DefaultGenerators.DefaultPageGenerators
{
    public static class FooterGenerator
    {
        public static async Task GenerateFooterAsync(AppDbContext context)
        {
            await context.Footers.AddAsync(new Footer { 
            InstagramLink= "https://www.instagram.com/rashidli_vahid/",
            LinkedInLink= "https://www.linkedin.com/in/vahid-rashidli-52302b21b/",
            TwitterLink= "https://twitter.com/VRashidli",
            YoutubeLink="",
            Content= "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure deleniti debitis minima sapiente? Recusandae, magnam natus! Id nisi, culpa fuga quasi rerum sed sunt enim aut magni voluptatibus nobis nulla. Sint amet vero facilis. Asperiores iure at nihil, in necessitatibus nesciunt? Iste exercitationem dignissimos, praesentium perferendis accusamus facere alias accusantium, dolores explicabo voluptas velit assumenda! Non cupiditate exercitationem a quae."
            });
            await context.SaveChangesAsync();
        }
    }
}
