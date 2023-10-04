using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class CountyConfiguration : BaseEntityConfiguration<County>
    {
        public override void Configure(EntityTypeBuilder<County> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.City).WithMany(x => x.Counties).HasForeignKey(x => x.CityId);

            base.Configure(builder);
        }
    }
}
