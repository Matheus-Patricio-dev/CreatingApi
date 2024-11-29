using ApiCars.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCars.Data
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options)
        {
           
        }

        public DbSet<FabricanteModel> Fabricante { get; set; }
        public DbSet<CarModel> Car { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
