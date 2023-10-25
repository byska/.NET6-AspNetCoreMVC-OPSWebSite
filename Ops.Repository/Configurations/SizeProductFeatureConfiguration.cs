using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class SizeProductFeatureConfiguration:BaseEntityConfiguration<SizeProductFeature>
    {
        public void Configure(EntityTypeBuilder<SizeProductFeature> builder)
        {

            builder.HasOne(x => x.ProductFeature).WithMany(x => x.SizeProductFeatures).HasForeignKey(x => x.ProductFeatureId);
            builder.HasOne(x => x.Size).WithMany(x => x.SizeProductFeatures).HasForeignKey(x => x.SizeId);
            base.Configure(builder);
        }
    }
}
