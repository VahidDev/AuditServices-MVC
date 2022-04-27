using AuditServices.Models.Entities;
using AuditServices.Models.Pages;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuditServices.DAL
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<HomePageTrendingSectionPart> HomePageTrendingSectionParts { get; set; }
        public DbSet<HomePageTrendingSection> HomePageTrendingSections { get; set; }
        public DbSet<HomePageCard> HomePageCards { get; set; }
        public DbSet<FooterPartLink> FooterPartLinks { get; set; }
        public DbSet<FooterPart> FooterParts { get; set; }
        public DbSet<Footer> Footers { get; set; }
    }
}
