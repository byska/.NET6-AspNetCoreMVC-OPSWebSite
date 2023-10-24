using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class PhotoConfiguration : BaseEntityConfiguration<Photo>
    {
        public override void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.Property(x => x.PhotoUrl).IsRequired();
            builder.HasOne(x => x.ProductFeature).WithMany(x=>x.Photos).HasForeignKey(x => x.ProductFeatureId);
            builder.HasOne(x=>x.Color).WithMany(x=>x.Photos).HasForeignKey(x=>x.ColorId);
            base.Configure(builder);
        }
    }
}
