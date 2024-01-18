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
    public class ColorProductSeed : IEntityTypeConfiguration<ColorProduct>
    {
        public void Configure(EntityTypeBuilder<ColorProduct> builder)
        {
            builder.HasData(new ColorProduct { Id=1,ColorId=4,ProductId=1 });
            builder.HasData(new ColorProduct { Id=2,ColorId=2,ProductId=2 });
            builder.HasData(new ColorProduct { Id=3,ColorId=6,ProductId=3 });
            builder.HasData(new ColorProduct { Id=4,ColorId=7,ProductId=4 });
            builder.HasData(new ColorProduct { Id=5,ColorId=5,ProductId=5 });
            builder.HasData(new ColorProduct { Id=6,ColorId=7,ProductId=6});
            builder.HasData(new ColorProduct { Id=7,ColorId=6,ProductId=7 });
            builder.HasData(new ColorProduct { Id=8,ColorId=1,ProductId=8 });
            builder.HasData(new ColorProduct { Id=9,ColorId=6,ProductId=9 });
            builder.HasData(new ColorProduct { Id=10,ColorId=7,ProductId=10 });
            builder.HasData(new ColorProduct { Id=11,ColorId=1,ProductId=11 });
            builder.HasData(new ColorProduct { Id=12,ColorId=1,ProductId=12 });
            builder.HasData(new ColorProduct { Id=13,ColorId=1,ProductId=13 });
            builder.HasData(new ColorProduct { Id=14,ColorId=8,ProductId=14 });
            builder.HasData(new ColorProduct { Id=15,ColorId=7,ProductId=15 });
            builder.HasData(new ColorProduct { Id=16,ColorId=6,ProductId=16 });
            builder.HasData(new ColorProduct { Id=17,ColorId=9,ProductId=17 });
            builder.HasData(new ColorProduct { Id=18,ColorId=1,ProductId=18 });
        }
    }
}
