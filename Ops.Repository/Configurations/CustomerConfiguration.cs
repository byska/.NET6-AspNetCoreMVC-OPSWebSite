using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class CustomerConfiguration : BaseUserConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.Addresses).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(11);

            base.Configure(builder);
        }
    }
}
