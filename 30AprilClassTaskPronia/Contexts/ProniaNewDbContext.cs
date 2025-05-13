using _30AprilClassTaskPronia.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _30AprilClassTaskPronia.Contexts;

public class ProniaNewDbContext:IdentityDbContext<User, IdentityRole<Guid>,Guid>

{

    public ProniaNewDbContext(DbContextOptions opt) : base(opt)
    {
        
    }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseSqlServer("Server=DESKTOP-6C57TUE\\SQLEXPRESS;Database=ProniaNewDb;Trusted_Connection=true;TrustServerCertificate=true");
    //    base.OnConfiguring(optionsBuilder);
    //}
    public DbSet<Service> Services { get; set; }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
}


