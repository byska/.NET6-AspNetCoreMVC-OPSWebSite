using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Seeds
{
    public class ProductOrderSeed : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.HasData(new ProductOrder { Id = 1, OrderId = 1, ProductId = 1,Amount=1 },
                new ProductOrder { Id = 2, OrderId = 1, ProductId = 2,Amount=2 },
                new ProductOrder { Id = 3, OrderId = 2, ProductId = 3,Amount=1 },
                new ProductOrder { Id = 4, OrderId = 2, ProductId = 2,Amount=2 },
                new ProductOrder { Id = 5, OrderId = 3, ProductId = 4,Amount=2 },
                new ProductOrder { Id = 6, OrderId = 4, ProductId = 5,Amount=2 });
        }
    }
}
