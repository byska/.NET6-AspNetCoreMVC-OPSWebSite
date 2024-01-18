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
            builder.HasData(new Stock { Id=1, Stocks=10,ProductId=1,ColorId=4,SizeId=1 });
            builder.HasData(new Stock { Id=2, Stocks=20,ProductId=1,ColorId=4,SizeId=2});
            builder.HasData(new Stock { Id=3, Stocks=20,ProductId=1,ColorId=4,SizeId=3 });

            builder.HasData(new Stock { Id=4, Stocks=20,ProductId=2,ColorId=2,SizeId=1 });
            builder.HasData(new Stock { Id=5, Stocks=20,ProductId=2,ColorId=2,SizeId=2});
            builder.HasData(new Stock { Id=6, Stocks=20,ProductId=2,ColorId=2,SizeId=3 });

            builder.HasData(new Stock { Id=7, Stocks=20,ProductId=3,ColorId=6,SizeId=1 });
            builder.HasData(new Stock { Id=8, Stocks=20,ProductId=3,ColorId=6,SizeId=2 });
            builder.HasData(new Stock { Id=9, Stocks=20,ProductId=3,ColorId=6,SizeId=3 });

            builder.HasData(new Stock { Id=10, Stocks=20,ProductId=4,ColorId=7,SizeId=1 });
            builder.HasData(new Stock { Id=11, Stocks=20,ProductId=4,ColorId=7,SizeId=3 });

            builder.HasData(new Stock { Id=12, Stocks=20,ProductId=5,ColorId=5,SizeId=1 });
            builder.HasData(new Stock { Id=13, Stocks=20,ProductId=5,ColorId=5,SizeId=2 });

            builder.HasData(new Stock { Id=14, Stocks=20,ProductId=6,ColorId=7,SizeId=1 });
            builder.HasData(new Stock { Id=15, Stocks=20,ProductId=6,ColorId=7,SizeId=2 });
            builder.HasData(new Stock { Id=16, Stocks=20,ProductId=6,ColorId=7,SizeId=3 });

            builder.HasData(new Stock { Id=17, Stocks=20,ProductId=7,ColorId=6,SizeId=1 });

            builder.HasData(new Stock { Id=18, Stocks=20,ProductId=8,ColorId=1,SizeId=2 });

            builder.HasData(new Stock { Id=19, Stocks=20,ProductId=9,ColorId=6,SizeId=2 });

            builder.HasData(new Stock { Id=20, Stocks=20,ProductId=10,ColorId=7,SizeId=1 });
            builder.HasData(new Stock { Id=21, Stocks=20,ProductId=10,ColorId=7,SizeId=2 });
            builder.HasData(new Stock { Id=22, Stocks=20,ProductId=10,ColorId=7,SizeId=3 });

            builder.HasData(new Stock { Id=23, Stocks=20,ProductId=11,ColorId=1,SizeId=2 });
            builder.HasData(new Stock { Id=24, Stocks=20,ProductId=11,ColorId=1,SizeId=3 });

            builder.HasData(new Stock { Id=25, Stocks=20,ProductId=12,ColorId=1,SizeId=3 });

            builder.HasData(new Stock { Id=26, Stocks=20,ProductId=13,ColorId=1,SizeId=3 });

            builder.HasData(new Stock { Id=27, Stocks=20,ProductId=14,ColorId=8,SizeId=1 });

            builder.HasData(new Stock { Id=28, Stocks=20,ProductId=15,ColorId=7,SizeId=1 });
            builder.HasData(new Stock { Id=29, Stocks=20,ProductId=15,ColorId=7,SizeId=3 });

            builder.HasData(new Stock { Id=30, Stocks=20,ProductId=16,ColorId=6,SizeId=1 });
            builder.HasData(new Stock { Id=31, Stocks=20,ProductId=17,ColorId=9,SizeId=2 });
            builder.HasData(new Stock { Id=32, Stocks=20,ProductId=18,ColorId=1,SizeId=3 });
        }
    }
}
