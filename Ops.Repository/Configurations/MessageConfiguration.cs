using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class MessageConfiguration:BaseEntityConfiguration<Message>
    {
        public override void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Subject).IsRequired().HasMaxLength(75);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(255);
            base.Configure(builder);
        }
    }
}
