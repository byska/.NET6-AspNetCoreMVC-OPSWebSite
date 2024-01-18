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
    public class PhotoSeed : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasData(new Photo { Id=1, PhotoUrl= "tişört1.jpeg", ProductId=1,ColorId=4 });
            builder.HasData(new Photo { Id=2, PhotoUrl= "tişört2.jpeg", ProductId=2,ColorId=2 });
            builder.HasData(new Photo { Id=3, PhotoUrl= "tişört3.jpeg", ProductId=3,ColorId=6 });
            builder.HasData(new Photo { Id=4, PhotoUrl= "tişört4.jpeg", ProductId=4,ColorId=7 });
            builder.HasData(new Photo { Id=5, PhotoUrl= "tişört5.jpeg", ProductId=5,ColorId=5 });
            builder.HasData(new Photo { Id=6, PhotoUrl= "tişört6.jpeg", ProductId=6,ColorId=7});
            builder.HasData(new Photo { Id=7, PhotoUrl= "hoodie1.jpeg", ProductId=7,ColorId=6 });
            builder.HasData(new Photo { Id=8, PhotoUrl= "hoodie2.jpeg", ProductId=8,ColorId=1 });
            builder.HasData(new Photo { Id=9, PhotoUrl= "hoodie3.jpeg", ProductId=9,ColorId=6 });
            builder.HasData(new Photo { Id=10, PhotoUrl= "hoodie4.jpeg", ProductId=10,ColorId=7 });
            builder.HasData(new Photo { Id=11, PhotoUrl= "hoodie5.jpeg", ProductId=11,ColorId=1 });
            builder.HasData(new Photo { Id=12, PhotoUrl= "hoodie6.jpeg", ProductId=12,ColorId=1 });
            builder.HasData(new Photo { Id=13, PhotoUrl= "sweat1.jpeg", ProductId=13,ColorId=1 });
            builder.HasData(new Photo { Id=14, PhotoUrl= "sweat2.jpeg", ProductId=14,ColorId=8 });
            builder.HasData(new Photo { Id=15, PhotoUrl= "sweat3.jpeg", ProductId=15,ColorId=7 });
            builder.HasData(new Photo { Id=16, PhotoUrl= "sweat4.jpeg", ProductId=16,ColorId=6 });
            builder.HasData(new Photo { Id=17, PhotoUrl= "sweat5.jpeg", ProductId=17,ColorId=9 });
            builder.HasData(new Photo { Id=18, PhotoUrl= "sweat6.jpeg", ProductId=18,ColorId=1 });
        }
    }
}
