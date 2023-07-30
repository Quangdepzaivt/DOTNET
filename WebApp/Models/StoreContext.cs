using Microsoft.EntityFrameworkCore;
namespace WebApp.Models;
public class StoreContext : DbContext{

    public StoreContext(DbContextOptions options): base(options){
    }
    public DbSet<Brand> Brands { get; set; } = null!;
    public DbSet<Category> Categories { get; set; }
}