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
            builder.HasData(new Photo { Id=1, PhotoUrl="Deneme",ProductId=1,ColorId=1 });
            builder.HasData(new Photo { Id=2, PhotoUrl="Deneme", ProductId=1,ColorId=1 });
            builder.HasData(new Photo { Id=3, PhotoUrl="Deneme", ProductId=1,ColorId=1 });
        }
    }
}
