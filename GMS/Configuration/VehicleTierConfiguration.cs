using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using GMS.Entities.Models;

namespace GMS.Configuration
{
    public class VehicleTierConfiguration : IEntityTypeConfiguration<VehicleTier>
    {
        public void Configure(EntityTypeBuilder<VehicleTier> builder)
        {
            builder.HasData(
                new VehicleTier { Id = 1, Name = "Standard", Description = "Basic vehicle tier for everyday rides." },
                new VehicleTier { Id = 2, Name = "Premium", Description = "Comfortable rides with experienced drivers and newer vehicles." },
                new VehicleTier { Id = 3, Name = "Luxury", Description = "High-end vehicles offering top-tier comfort and amenities." }
            );
        }
    }
}
