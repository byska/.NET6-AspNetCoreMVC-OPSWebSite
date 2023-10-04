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
    public class OrderSeed : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(new Order { Id=1, CustomerId=1, OrderStatus=Core.Enums.OrderStatus.Taken, ProductId=1, Status=Core.Enums.Status.Added },
                new Order { Id = 2, CustomerId = 1, OrderStatus = Core.Enums.OrderStatus.Delivered, ProductId = 2, Status = Core.Enums.Status.Added },
                new Order { Id = 3, CustomerId = 1, OrderStatus = Core.Enums.OrderStatus.Shipping, ProductId = 3, Status = Core.Enums.Status.Added },
                new Order { Id = 4, CustomerId = 2, OrderStatus = Core.Enums.OrderStatus.Preparing, ProductId = 1, Status = Core.Enums.Status.Added });
        }
    }
}
