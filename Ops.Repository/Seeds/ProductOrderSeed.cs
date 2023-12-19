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
            builder.HasData(new ProductOrder { Id = 1, OrderId = 1, ProductId = 1 },
                new ProductOrder { Id = 2, OrderId = 1, ProductId = 2 },
                new ProductOrder { Id = 3, OrderId = 2, ProductId = 3 },
                new ProductOrder { Id = 4, OrderId = 2, ProductId = 2 });
        }
    }
}
