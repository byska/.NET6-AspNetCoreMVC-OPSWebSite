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
            builder.HasData(new ColorProduct { Id=1,ColorId=1,ProductId=1 });
            builder.HasData(new ColorProduct { Id=2,ColorId=2,ProductId=1 });
            builder.HasData(new ColorProduct { Id=3,ColorId=2,ProductId=2 });
            builder.HasData(new ColorProduct { Id=4,ColorId=2,ProductId=3 });
        }
    }
}
