using ApiCars.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCars.Data
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options)
        {
           
        }

        public DbSet<fabricanteModel> Fabricante { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
