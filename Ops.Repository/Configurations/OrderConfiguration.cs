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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.TotalPrice).IsRequired();
            builder.HasOne(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId).OnDelete(DeleteBehavior.ClientSetNull);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Status).IsRequired();
        }
    }
}
