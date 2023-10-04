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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category { Id = 1, Name = "Tişört", Status = Core.Enums.Status.Added },
                new Category { Id = 2, Name = "Sweat", Status = Core.Enums.Status.Added },
                new Category { Id = 3, Name = "Çanta", Status = Core.Enums.Status.Added });
        }
    }
}
