using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Seeds
{
    public class StockSeed : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasData(new Stock { Id=1, Stocks=10,ProductFeatureId=1,ColorId=1,SizeId=1 });
            builder.HasData(new Stock { Id=2, Stocks=20,ProductFeatureId=2,ColorId=1,SizeId=1 });
        }
    }
}
