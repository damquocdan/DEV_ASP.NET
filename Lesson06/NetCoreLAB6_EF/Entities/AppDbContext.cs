using Microsoft.EntityFrameworkCore;
using NetCoreLAB6_EF.Models;

namespace NetCoreLAB6_EF.Entities
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> books { get; set; }

    }
}
