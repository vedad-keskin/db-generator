using eCommerce.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GMS.Configuration
{
    public class UserRolesConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(
                new UserRole
                {
                    Id = 1,
                    UserId = 1,
                    RoleId = 1, // Administrator
                    DateAssigned = DateTime.UtcNow
                },
                new UserRole
                {
                    Id = 2,
                    UserId = 2,
                    RoleId = 1, // Administrator
                    DateAssigned = DateTime.UtcNow
                }
            );
        }
    }
}
