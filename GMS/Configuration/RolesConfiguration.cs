using eCommerce.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GMS.Configuration
{
    public class RolesConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = 1,
                    Name = "Administrator",
                    Description = "System administrator with full access.",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                },
                new Role
                {
                    Id = 2,
                    Name = "User",
                    Description = "Regular application user.",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                },
                new Role
                {
                    Id = 3,
                    Name = "Driver",
                    Description = "Handles deliveries and transport.",
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true
                }
            );
        }
    }
}
