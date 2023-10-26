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
            builder.HasData(new SizeProduct { Id=2, ProductId=2, SizeId=2, });
            builder.HasData(new SizeProduct { Id=3, ProductId=3, SizeId=3, });
        }
    }
}
