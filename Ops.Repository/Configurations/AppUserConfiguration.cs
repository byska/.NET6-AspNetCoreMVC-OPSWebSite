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
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("Users");

            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).HasMaxLength(50);
            //builder.Property(x => x.PersonelDataProtection).IsRequired();
            //builder.Property(x => x.MembershipAgreement).IsRequired();
            builder.Property(x => x.CreatedDate).HasConversion(typeof(DateTime)).HasDefaultValue(DateTime.Now);

        }
    }
}
