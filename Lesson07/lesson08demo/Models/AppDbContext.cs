using lesson08demo.Models;
using Microsoft.EntityFrameworkCore;
namespace Lesson08.Lab.Models
{
    public class AppDbContext : DbContext { 
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Banner> Banners { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // khai báo thêm ràng buộc UNIQUE 
        modelBuilder.Entity<Category>()
        .HasIndex(c => c.Name)
        .IsUnique();
        // khai báo khóa chính trên nhiều trường cho bảng OrderDetail  //modelBuilder.Entity<OrderDetail>() 
        // .HasKey(c => new { c.OrderId, c.ProductId }) 
        modelBuilder.Entity<OrderDetail>()
        .HasIndex(c => new { c.OrderId, c.ProductId }).IsUnique();
    }
} 
} 
