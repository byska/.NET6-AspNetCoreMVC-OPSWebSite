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
    public class AddressConfiguration : BaseEntityConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(128);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(11);
            builder.Property(x => x.ZIP).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.City).WithMany(x => x.Addresses).HasForeignKey(x => x.CityId);
            builder.HasOne(x => x.County).WithMany(x => x.Addresses).HasForeignKey(x => x.CountyId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x => x.Customer).WithMany(x => x.Addresses).HasForeignKey(x => x.CustomerId);

            base.Configure(builder);
        }

    }
}
