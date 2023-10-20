using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class HomeSliderConfiguration : BaseEntityConfiguration<HomeSlider>
    {
        public override void Configure(EntityTypeBuilder<HomeSlider> builder)
        {
            builder.Property(x=>x.PhotoUrl).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Title).IsRequired(false).HasMaxLength(50);
            builder.Property(x=>x.Subtitle).IsRequired(false).HasMaxLength(50);
            base.Configure(builder);
        }
    }
}
