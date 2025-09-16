using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialApi.Domain.Entities;

namespace TutorialApi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");

            Product product1 = new()
            {
                Id = 1,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Price = faker.Finance.Amount(100, 1000),
                BrandId = 1,
                Discount = faker.Random.Decimal(0, 10),
                CreatedDate= DateTime.Now,
                IsDeleted= false
            };

            Product product2 = new()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                Price = faker.Finance.Amount(100, 1000),
                BrandId = 3,
                Discount = faker.Random.Decimal(0, 10),
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            builder.HasData(product1, product2);
        }
    }
}
