using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class ProductConfiguration : BaseEntityConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Size).IsRequired();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(128);

            builder.HasOne(x => x.productType).WithMany(x => x.Products).HasForeignKey(x => x.productTypeId);

            base.Configure(builder);
        }
    }
}
