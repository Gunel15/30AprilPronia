using _30AprilClassTaskPronia.Models;
using Microsoft.EntityFrameworkCore;

namespace _30AprilClassTaskPronia.Contexts;

    public class ProniaNewDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6C57TUE\\SQLEXPRESS;Database=ProniaNewDb;Trusted_Connection=true;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Service> Services { get; set; }
    }


                                                        