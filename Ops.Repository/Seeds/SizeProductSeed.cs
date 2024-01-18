using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Seeds
{
    public class SizeProductSeed : IEntityTypeConfiguration<SizeProduct>
    {
        public void Configure(EntityTypeBuilder<SizeProduct> builder)
        {
            builder.HasData(new SizeProduct { Id=1, ProductId=1, SizeId=1, });
            builder.HasData(new SizeProduct { Id=2, ProductId=1, SizeId=2, });
            builder.HasData(new SizeProduct { Id=3, ProductId=1, SizeId=3, });

            builder.HasData(new SizeProduct { Id=4, ProductId=2, SizeId=1, });
            builder.HasData(new SizeProduct { Id=5, ProductId=2, SizeId=2, });
            builder.HasData(new SizeProduct { Id=6, ProductId=2, SizeId=3, });

            builder.HasData(new SizeProduct { Id=7, ProductId=3, SizeId=1, });
            builder.HasData(new SizeProduct { Id=8, ProductId=3, SizeId=2, });
            builder.HasData(new SizeProduct { Id=9, ProductId=3, SizeId=3, });

            builder.HasData(new SizeProduct { Id=10, ProductId=4, SizeId=1, });
            builder.HasData(new SizeProduct { Id=11, ProductId=4, SizeId=3, });

            builder.HasData(new SizeProduct { Id=12, ProductId=5, SizeId=1, });
            builder.HasData(new SizeProduct { Id=13, ProductId=5, SizeId=2, });

            builder.HasData(new SizeProduct { Id=14, ProductId=6, SizeId=1, });
            builder.HasData(new SizeProduct { Id=15, ProductId=6, SizeId=2, });
            builder.HasData(new SizeProduct { Id=16, ProductId=6, SizeId=3, });

            builder.HasData(new SizeProduct { Id=17, ProductId=7, SizeId=1, });

            builder.HasData(new SizeProduct { Id=18, ProductId=8, SizeId=2, });

            builder.HasData(new SizeProduct { Id=19, ProductId=9, SizeId=2, });

            builder.HasData(new SizeProduct { Id=20, ProductId=10, SizeId=1, });
            builder.HasData(new SizeProduct { Id=21, ProductId=10, SizeId=2, });
            builder.HasData(new SizeProduct { Id=22, ProductId=10, SizeId=3, });

            builder.HasData(new SizeProduct { Id=23, ProductId=11, SizeId=2, });
            builder.HasData(new SizeProduct { Id=24, ProductId=11, SizeId=3, });

            builder.HasData(new SizeProduct { Id=25, ProductId=12, SizeId=3, });

            builder.HasData(new SizeProduct { Id=26, ProductId=13, SizeId=3, });

            builder.HasData(new SizeProduct { Id=27, ProductId=14, SizeId=1, });

            builder.HasData(new SizeProduct { Id=28, ProductId=15, SizeId=1, });
            builder.HasData(new SizeProduct { Id=29, ProductId=15, SizeId=3, });

            builder.HasData(new SizeProduct { Id=30, ProductId=16, SizeId=1, });
            builder.HasData(new SizeProduct { Id=31, ProductId=17, SizeId=2, });
            builder.HasData(new SizeProduct { Id=32, ProductId=18, SizeId=3, });
        }
    }
}
