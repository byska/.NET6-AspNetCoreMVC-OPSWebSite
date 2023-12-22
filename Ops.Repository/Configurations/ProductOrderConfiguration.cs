using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class ProductOrderConfiguration: IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.HasOne(x=>x.product).WithMany(x=>x.ProductOrders).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x=>x.order).WithMany(x=>x.OrderProducts).HasForeignKey(x=>x.OrderId);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
