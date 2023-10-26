using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class ColorProductConfiguration : BaseEntityConfiguration<ColorProduct>
    {
        public void Configure(EntityTypeBuilder<ColorProduct> builder)
        {
         
            builder.HasOne(x => x.Product).WithMany(x => x.ColorProducts).HasForeignKey(x=>x.ProductId);
            builder.HasOne(x => x.Color).WithMany(x => x.ColorProducts).HasForeignKey(x=>x.ColorId);
            base.Configure(builder);
        }
    }
}
