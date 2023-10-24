using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class StockConfiguration:BaseEntityConfiguration<Stock>
    {
        public override void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.Property(x => x.Stocks).IsRequired();
            builder.HasOne(x => x.ProductFeature).WithMany(x => x.Stocks).HasForeignKey(x => x.ProductFeatureId);
            builder.HasOne(x => x.Color).WithMany(x => x.Stocks).HasForeignKey(x => x.ColorId);
            builder.HasOne(x => x.Size).WithMany(x => x.Stocks).HasForeignKey(x => x.SizeId);
            base.Configure(builder);
        }
    }
}
