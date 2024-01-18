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
    public class ColorSeed : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.HasData(new Color { Id=1, Name="Black",  });
            builder.HasData(new Color { Id=2, Name="Blue", });
            builder.HasData(new Color { Id=3, Name="Yellow", });
            builder.HasData(new Color { Id=4, Name="Somon", });
            builder.HasData(new Color { Id=5, Name="Gray", });
            builder.HasData(new Color { Id=6, Name="Green", });
            builder.HasData(new Color { Id=7, Name="Beige", });
            builder.HasData(new Color { Id=8, Name="White", });
            builder.HasData(new Color { Id=9, Name="Orange", });
        }
    }
}
