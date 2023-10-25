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
    public class SizeSeed : IEntityTypeConfiguration<Size>
    {
        public void Configure(EntityTypeBuilder<Size> builder)
        {
            builder.HasData(new Size { Id=1, Name="Small", });
            builder.HasData(new Size { Id=2, Name="Medium", });
            builder.HasData(new Size { Id=3, Name="Large", });
        }
    }
}
