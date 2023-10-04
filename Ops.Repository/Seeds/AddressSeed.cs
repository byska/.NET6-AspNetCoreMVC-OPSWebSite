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
    public class AddressSeed : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(new Address { Id = 1, CustomerId = 1, CityId=1, CountyId=1, Status=Core.Enums.Status.Added, Description="Üsküdar metrobüse yakın" },
                new Address { Id = 2, CustomerId = 2, CityId = 1, CountyId = 1, Status = Core.Enums.Status.Added, Description = "Acıbadem metroya yakın" });
        }
    }
}
