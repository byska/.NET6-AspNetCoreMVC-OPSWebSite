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
    public class SizeProductFeatureSeed : IEntityTypeConfiguration<SizeProductFeature>
    {
        public void Configure(EntityTypeBuilder<SizeProductFeature> builder)
        {
            builder.HasData(new SizeProductFeature { Id=1, ProductFeatureId=1, SizeId=1, });
            builder.HasData(new SizeProductFeature { Id=2, ProductFeatureId=2, SizeId=2, });
            builder.HasData(new SizeProductFeature { Id=3, ProductFeatureId=3, SizeId=3, });
        }
    }
}
