using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMS.Configuration
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                new Vehicle
                {
                    Id = 1,
                    Name = "BMW Series 3",
                    LicensePlate = "BL-123-XYZ",
                    Color = "Black",
                    YearOfManufacture = 2018,
                    SeatsCount = 5,
                    StateMachine = "Accepted",
                    PetFriendly = true,
                    BrandId = 2, // BMW
                    UserId = 1,
                    VehicleTierId = 2 // Premium
                },
                new Vehicle
                {
                    Id = 2,
                    Name = "Škoda Octavia",
                    LicensePlate = "SA-456-ABC",
                    Color = "White",
                    YearOfManufacture = 2017,
                    SeatsCount = 5,
                    StateMachine = "Accepted",
                    PetFriendly = false,
                    BrandId = 1, // Škoda
                    UserId = 2,
                    VehicleTierId = 1 // Standard
                }
            );
        }
    }
}
