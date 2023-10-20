using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product { Id=1, CategoryId=1, Name="Tişört", Price=200, Stock=20, Status=Status.Added },
                new Product { Id = 2, CategoryId=1,  Name = "Kısa Kollu Tişört", Price = 150, Stock = 20, Status = Status.Added,Amount=10 },
                new Product { Id = 3, CategoryId = 1, Name = " Uzun Kollu Tişört", Price = 300, Stock = 20, Status = Status.Added,Amount=2 },
                new Product { Id = 4, CategoryId = 3, Name = "Çanta", Price = 400, Stock = 20, Status = Status.Added,Amount=20 },
                new Product { Id = 5, CategoryId = 2, Name = "Sweat", Price = 500, Stock = 20, Status = Status.Added,Amount=100 });
        }
    }
}
