using MayFlo.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
using MSSQLFlexCrud.DatatContext;

namespace MayFlo.API.Data
{
    public class BlogDbContext : AppDbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
