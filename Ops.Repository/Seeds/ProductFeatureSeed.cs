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
    public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(new ProductFeature { Id=1, Color="Sarı", Description="30 derecede yıkayınız", ProductId=1, Size=Core.Enums.Size.Large, Status=Core.Enums.Status.Added,PhotoUrl="adafa" },
                new ProductFeature { Id = 2, Color = "Mavi", Description = "30 derecede yıkayınız", ProductId = 2, Size = Core.Enums.Size.Small, Status = Core.Enums.Status.Added, PhotoUrl = "adafa" },
                new ProductFeature { Id = 3, Color = "Beyaz", Description = "30 derecede yıkayınız", ProductId = 3, Size = Core.Enums.Size.XLarge, Status = Core.Enums.Status.Added, PhotoUrl = "adafa" },
                new ProductFeature { Id = 4, Color = "Beyaz", Description = "30 derecede yıkayınız", ProductId = 4, Size = Core.Enums.Size.XLarge, Status = Core.Enums.Status.Added, PhotoUrl = "adafa" },
                new ProductFeature { Id = 5, Color = "Beyaz", Description = "30 derecede yıkayınız", ProductId = 5, Size = Core.Enums.Size.XLarge, Status = Core.Enums.Status.Added, PhotoUrl = "adafa" });
        }
    }
}
