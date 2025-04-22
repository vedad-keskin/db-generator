using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMS.Configuration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(
                new Brand { Id = 1, Name = "Škoda" },
                new Brand { Id = 2, Name = "BMW" },
                new Brand { Id = 3, Name = "Audi" },
                new Brand { Id = 4, Name = "Mercedes-Benz" },
                new Brand { Id = 5, Name = "Volkswagen" },
                new Brand { Id = 6, Name = "Toyota" },
                new Brand { Id = 7, Name = "Ford" },
                new Brand { Id = 8, Name = "Renault" },
                new Brand { Id = 9, Name = "Peugeot" },
                new Brand { Id = 10, Name = "Fiat" },
                new Brand { Id = 11, Name = "Kia" },
                new Brand { Id = 12, Name = "Hyundai" },
                new Brand { Id = 13, Name = "Opel" },
                new Brand { Id = 14, Name = "Mazda" },
                new Brand { Id = 15, Name = "Seat" }
            );
        }
    }
}
