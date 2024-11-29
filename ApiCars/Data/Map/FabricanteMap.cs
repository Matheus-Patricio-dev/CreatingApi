using ApiCars.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCars.Data.Map
{
    public class FabricanteMap : IEntityTypeConfiguration<FabricanteModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FabricanteModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
