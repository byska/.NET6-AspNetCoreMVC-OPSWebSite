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
            builder.HasData(new Comment { Id=1, CustomerId=1, Mark=5, Description="Çok güzel ürünler", ProductId=1, Status=Core.Enums.Status.Added },
               new Comment { Id = 2, CustomerId = 1, Mark = 4, Description = "Çok güzel ürünler", ProductId = 2, Status = Core.Enums.Status.Added },
               new Comment { Id = 3, CustomerId = 2, Mark = 5, Description = "Çok güzel ürünler", ProductId = 1, Status = Core.Enums.Status.Added },
               new Comment { Id = 4, CustomerId = 2, Mark = 5, Description = "Çok güzel ürünler", ProductId = 2, Status = Core.Enums.Status.Added },
                 new Comment { Id = 5, CustomerId = 1, Mark = 1, Description = "Çok demode", ProductId = 1, Status = Core.Enums.Status.Added },
                  new Comment { Id = 6, CustomerId = 2, Mark = 2, Description = "Kibar duruyor ama pahalı", ProductId = 1, Status = Core.Enums.Status.Added },
                   new Comment { Id = 7, CustomerId = 1, Mark = 3, Description = "Ehhhhh fena sayılmaz. Birdaha almam ama. :)", ProductId = 1, Status = Core.Enums.Status.Added },
                    new Comment { Id = 8, CustomerId = 2, Mark = 4, Description = "Çok güzel ürünler. Baya beğendim. Alınır", ProductId = 1, Status = Core.Enums.Status.Added },
                     new Comment { Id = 9, CustomerId = 1, Mark = 5, Description = "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", ProductId = 1, Status = Core.Enums.Status.Added },
                     new Comment { Id = 10, CustomerId = 1, Mark = 2, Description = "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", ProductId = 1, Status = Core.Enums.Status.Added },
                        new Comment { Id = 11, CustomerId = 1, Mark = 5, Description = "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", ProductId = 1, Status = Core.Enums.Status.Added },
                           new Comment { Id = 12, CustomerId = 1, Mark = 1, Description = "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", ProductId = 1, Status = Core.Enums.Status.Added },
                              new Comment { Id = 13, CustomerId = 1, Mark = 2, Description = "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", ProductId = 1, Status = Core.Enums.Status.Added }



                     )
                ;
        }
    }
}
