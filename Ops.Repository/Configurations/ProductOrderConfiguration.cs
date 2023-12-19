using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class ProductOrderConfiguration:BaseEntityConfiguration<ProductOrder>
    {
        public override void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.HasOne(x=>x.product).WithMany(x=>x.ProductOrders).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x=>x.order).WithMany(x=>x.OrderProducts).HasForeignKey(x=>x.OrderId);
            base.Configure(builder);
        }
    }
}
