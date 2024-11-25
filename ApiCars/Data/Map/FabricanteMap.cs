using ApiCars.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCars.Data.Map
{
    public class FabricanteMap : IEntityTypeConfiguration<fabricanteModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<fabricanteModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
