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
    public class CommentSeed : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(new Comment { Id=1, CustomerId=1, Mark=5, Description="Çok güzel ürünler", ProductId=1, Status=Core.Enums.Status.Added},
               new Comment { Id = 2, CustomerId = 1, Mark = 4, Description = "Çok güzel ürünler", ProductId = 2, Status = Core.Enums.Status.Added },
               new Comment { Id = 3, CustomerId = 2, Mark = 5, Description = "Çok güzel ürünler", ProductId = 1, Status = Core.Enums.Status.Added },
               new Comment { Id = 4, CustomerId = 2, Mark = 5, Description = "Çok güzel ürünler", ProductId = 2, Status = Core.Enums.Status.Added });
        }
    }
}
