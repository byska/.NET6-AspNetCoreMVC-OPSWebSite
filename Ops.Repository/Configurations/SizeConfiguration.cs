using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class SizeConfiguration : BaseEntityConfiguration<Size>
    {
        public override void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.HasOne(x => x.ProductFeature).WithMany(x => x.Sizes).HasForeignKey(x => x.ProductFeatureId);
            base.Configure(builder);
        }
    }
   
}
