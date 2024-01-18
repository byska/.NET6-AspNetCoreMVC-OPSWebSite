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
            builder.HasData(new Order { Id=1, CustomerId=1, OrderStatus=Core.Enums.OrderStatus.Taken, Status=Core.Enums.Status.Added,AddressId=1 },
                new Order { Id = 2, CustomerId = 1, OrderStatus = Core.Enums.OrderStatus.Delivered, Status = Core.Enums.Status.Added ,AddressId=2 },
                new Order { Id = 3, CustomerId = 1, OrderStatus = Core.Enums.OrderStatus.Shipping, Status = Core.Enums.Status.Added, AddressId = 1 },
                new Order { Id = 4, CustomerId = 2, OrderStatus = Core.Enums.OrderStatus.Preparing, Status = Core.Enums.Status.Added, AddressId=2 });
        }
    }
}
