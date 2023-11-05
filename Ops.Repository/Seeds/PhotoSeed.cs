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
            builder.HasData(new Photo { Id=1, PhotoUrl="tshirt-1.jpeg", ProductId=1,ColorId=1 });
            builder.HasData(new Photo { Id=2, PhotoUrl="tshirt-1.jpeg", ProductId=1,ColorId=1 });
            builder.HasData(new Photo { Id=3, PhotoUrl="tshirt-1.jpeg", ProductId=1,ColorId=1 });
            builder.HasData(new Photo { Id=4, PhotoUrl="tshirt-1.jpeg", ProductId=2,ColorId=1 });
            builder.HasData(new Photo { Id=5, PhotoUrl="tshirt-1.jpeg", ProductId=3,ColorId=1 });
            builder.HasData(new Photo { Id=6, PhotoUrl="tshirt-1.jpeg", ProductId=4,ColorId=1 });
        }
    }
}
