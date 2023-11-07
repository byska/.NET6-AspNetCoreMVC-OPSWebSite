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
            builder.HasData(new Category { Id = 1, Name = "Tişört Regular", Status = Core.Enums.Status.Added },
                new Category { Id = 2, Name = "Tişört Oversize", Status = Core.Enums.Status.Added },
                new Category { Id = 3, Name = "Hoodie", Status = Core.Enums.Status.Added },
                new Category { Id = 4, Name = "Sweatshirt", Status = Core.Enums.Status.Added },
                new Category { Id = 5, Name = "Kol Çantası", Status = Core.Enums.Status.Added },
                new Category { Id = 6, Name = "Cüzdan", Status = Core.Enums.Status.Added },
                new Category { Id = 7, Name = "Baf", Status = Core.Enums.Status.Added }
                );
        }
    }
}
