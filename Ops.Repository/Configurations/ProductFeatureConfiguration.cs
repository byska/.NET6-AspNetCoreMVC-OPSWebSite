using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class ProductFeatureConfiguration : BaseEntityConfiguration<ProductFeature>
    {
        public override void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.Property(x => x.Size).IsRequired();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Color).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PhotoUrl).IsRequired().HasMaxLength(100);

            builder.HasOne(x => x.Product).WithOne(x => x.ProductFeature).HasForeignKey<ProductFeature>(x => x.ProductId);

            base.Configure(builder);
        }
    }
}
