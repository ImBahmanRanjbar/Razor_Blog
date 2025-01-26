using Microsoft.EntityFrameworkCore;
using Razor_Blog.Mapping;
using Razor_Blog.Models;

namespace Razor_Blog
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        public DbSet<Article>   articles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
