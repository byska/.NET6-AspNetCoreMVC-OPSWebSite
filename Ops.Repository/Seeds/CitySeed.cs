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
    public class CitySeed : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(new City { Id = 1, Status = Core.Enums.Status.Added, Name = "Istanbul" },
                new City { Id = 2, Status = Core.Enums.Status.Added, Name = "Ankara" });
        }
    }
}
