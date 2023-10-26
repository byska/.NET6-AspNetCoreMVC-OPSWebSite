using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class SizeProductConfiguration:BaseEntityConfiguration<SizeProduct>
    {
        public void Configure(EntityTypeBuilder<SizeProduct> builder)
        {

            builder.HasOne(x => x.Product).WithMany(x => x.SizeProducts).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Size).WithMany(x => x.SizeProducts).HasForeignKey(x => x.SizeId);
            base.Configure(builder);
        }
    }
}
