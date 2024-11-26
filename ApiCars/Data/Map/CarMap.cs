using ApiCars.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace ApiCars.Data.Map
{
    public class CarMap : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Model).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Type).IsRequired().HasMaxLength(255);
            builder.Property(x => x.fabricationYear).IsRequired();
            builder.Property(x => x.fabricanteId).IsRequired();

            builder.HasOne(x => x.fabricante);

        }
    }
}
