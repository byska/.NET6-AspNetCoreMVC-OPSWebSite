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
    public class ColorProductFeatureConfiguration : BaseEntityConfiguration<ColorProductFeature>
    {
        public void Configure(EntityTypeBuilder<ColorProductFeature> builder)
        {
         
            builder.HasOne(x => x.ProductFeature).WithMany(x => x.ColorProductFeatures).HasForeignKey(x=>x.ProductFeatureId);
            builder.HasOne(x => x.Color).WithMany(x => x.ColorProductFeatures).HasForeignKey(x=>x.ColorId);
            base.Configure(builder);
        }
    }
}
