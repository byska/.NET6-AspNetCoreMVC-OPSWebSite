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
    public class CountySeed : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasData(new District { Id = 1, CityId = 1, Status = Core.Enums.Status.Added, Name = "Fatih" },
               new District { Id = 2, CityId = 1, Status = Core.Enums.Status.Added, Name = "Üsküdar" },
               new District { Id = 3, CityId = 2, Status = Core.Enums.Status.Added, Name = "Kızılay" },
               new District { Id = 4, CityId = 2, Status = Core.Enums.Status.Added, Name = "Çankaya" });
        }
    }
}
