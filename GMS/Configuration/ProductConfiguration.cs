using GMS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GMS.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Whey Protein",
                    Description = "High-quality whey protein powder for muscle recovery and growth.",
                    Price = 49.99m,
                    StockQuantity = 100,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                    SKU = "WHEY-001"
                },
                new Product
                {
                    Id = 2,
                    Name = "Creatine Monohydrate",
                    Description = "Pure creatine monohydrate to enhance strength and performance.",
                    Price = 29.99m,
                    StockQuantity = 150,
                    IsActive = true,
                    CreatedAt = DateTime.UtcNow,
                    SKU = "CREA-001"
                }
            );
        }
    }
}
