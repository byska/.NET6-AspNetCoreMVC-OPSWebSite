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
            builder.HasOne(x => x.Product).WithOne(x => x.Stock).HasForeignKey<Stock>(x => x.ProductId);
            builder.HasOne(x => x.Color).WithOne(x => x.Stock).HasForeignKey<Stock>(x => x.ColorId);
            builder.HasOne(x => x.Size).WithOne(x => x.Stock).HasForeignKey<Stock>(x => x.SizeId);

        }
    }
}
