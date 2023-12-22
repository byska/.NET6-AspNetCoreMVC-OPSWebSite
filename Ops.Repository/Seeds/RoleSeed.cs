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
    public class RoleSeed : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(new AppRole { Id = 1, Name="admin",Status=Core.Enums.Status.Added,DisplayName="Yönetici",NormalizedName="ADMIN"}, 
                new AppRole { Id=2, Name="customer", Status = Core.Enums.Status.Added,DisplayName="Müşteri",NormalizedName = "CUSTOMER" });
        }
    }
}
