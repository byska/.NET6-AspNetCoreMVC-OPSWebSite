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
    public class ColorProductFeatureSeed : IEntityTypeConfiguration<ColorProductFeature>
    {
        public void Configure(EntityTypeBuilder<ColorProductFeature> builder)
        {
            builder.HasData(new ColorProductFeature { Id=1,ColorId=1,ProductFeatureId=1 });
            builder.HasData(new ColorProductFeature { Id=2,ColorId=2,ProductFeatureId=1 });
            builder.HasData(new ColorProductFeature { Id=3,ColorId=2,ProductFeatureId=2 });
            builder.HasData(new ColorProductFeature { Id=4,ColorId=2,ProductFeatureId=3 });
        }
    }
}
