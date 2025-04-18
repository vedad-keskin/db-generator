using eCommerce.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace eCommerce.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    Username = "johndoe",
                    PasswordHash = "hashed_password_1", // Replace with actual hash
                    PasswordSalt = "salt_1",             // Replace with actual salt
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                    LastLoginAt = null,
                    PhoneNumber = "123-456-7890"
                },
                new User
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    Username = "janesmith",
                    PasswordHash = "hashed_password_2", // Replace with actual hash
                    PasswordSalt = "salt_2",             // Replace with actual salt
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                    LastLoginAt = null,
                    PhoneNumber = "987-654-3210"
                }
            );
        }
    }
}
