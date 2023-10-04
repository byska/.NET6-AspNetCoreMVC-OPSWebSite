using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Configurations
{
    public class CommentConfiguration : BaseEntityConfiguration<Comment>
    {
        public override void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(x => x.Description).IsRequired().HasMaxLength(128);
            builder.Property(x => x.Mark).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Customer).WithMany(x => x.Comments).HasForeignKey(x => x.CustomerId);
            builder.HasOne(x => x.Product).WithMany(x => x.Comments).HasForeignKey(x => x.ProductId);

            base.Configure(builder);
        }
    }
}
