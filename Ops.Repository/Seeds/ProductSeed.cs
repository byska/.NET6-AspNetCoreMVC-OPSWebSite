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
            builder.HasData(new Product { Id = 1, CategoryId = 1, Name = "Tişört", Price = 200, Status = Status.Added },
                new Product { Id = 2, CategoryId = 1, Name = "Tişört", Price = 150, Status = Status.Added },
                new Product { Id = 3, CategoryId = 1, Name = "Tişört", Price = 300, Status = Status.Added },
                new Product { Id = 4, CategoryId = 1, Name = "Tişört", Price = 300, Status = Status.Added },
                new Product { Id = 5, CategoryId = 1, Name = "Tişört", Price = 300, Status = Status.Added },
                new Product { Id = 6, CategoryId = 1, Name = "Tişört", Price = 400, Status = Status.Added },

                new Product { Id = 7, CategoryId = 3, Name = "Hoodie", Price = 400, Status = Status.Added },
                new Product { Id = 8, CategoryId = 3, Name = "Hoodie", Price = 500, Status = Status.Added },
                new Product { Id = 9, CategoryId = 3, Name = "Hoodie", Price = 250, Status = Status.Added },
                new Product { Id = 10, CategoryId = 3, Name = "Hoodie", Price = 350, Status = Status.Added },
                new Product { Id = 11, CategoryId = 3, Name = "Hoodie", Price = 450, Status = Status.Added },
                new Product { Id = 12, CategoryId = 3, Name = "Hoodie", Price = 1050, Status = Status.Added },

                new Product { Id = 13, CategoryId = 4, Name = "Sweat", Price = 1050, Status = Status.Added },
                new Product { Id = 14, CategoryId = 4, Name = "Sweat", Price = 1050, Status = Status.Added },
                new Product { Id = 15, CategoryId = 4, Name = "Sweat", Price = 1050, Status = Status.Added },
                new Product { Id = 16, CategoryId = 4, Name = "Sweat", Price = 1050, Status = Status.Added },
                new Product { Id = 17, CategoryId = 4, Name = "Sweat", Price = 1050, Status = Status.Added },
                new Product { Id = 18, CategoryId = 4, Name = "Sweat", Price = 1050, Status = Status.Added },

                 new Product { Id = 19, CategoryId = 7, Name = "Baf", Price = 400, Status = Status.Added },
            new Product { Id = 20, CategoryId = 5, Name = "Çanta", Price = 400, Status = Status.Added },
                new Product { Id = 21, CategoryId = 6, Name = "Cüzdan", Price = 400, Status = Status.Added });
        }
    }
}
