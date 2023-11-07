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
            builder.HasData(new Product { Id=1, CategoryId=1, Name="Tişört", Price=200, Status=Status.Added,Amount=200 },
                new Product { Id = 2, CategoryId=1,  Name = "Kısa Kollu Tişört", Price = 150,  Status = Status.Added,Amount=10 },
                new Product { Id = 3, CategoryId = 2, Name = " Uzun Kollu Tişört", Price = 300,  Status = Status.Added,Amount=2 },
                new Product { Id = 4, CategoryId = 5, Name = "Çanta", Price = 400, Status = Status.Added,Amount=20 },
                new Product { Id = 5, CategoryId = 6, Name = "Cüzdan", Price = 400, Status = Status.Added,Amount=20 },
                new Product { Id = 6, CategoryId = 3, Name = "Hoodie", Price = 400, Status = Status.Added,Amount=20 },
                new Product { Id = 7, CategoryId = 7, Name = "Baf", Price = 400, Status = Status.Added,Amount=20 },
                new Product { Id = 8, CategoryId = 4, Name = "Sweat", Price = 500,  Status = Status.Added,Amount=100 });
        }
    }
}
