using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using Ops.Core.Enums;
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
            builder.HasData(new ProductFeature { Id=1, Color=new List<Color> { Color.White,Color.Black,Color.Yellow}, Description="30 derecede yıkayınız", ProductId=1, Size= new List<Size> { Size.Small,Size.Large}, Status=Core.Enums.Status.Added,PhotoUrl = new List<string> { "deneme","deneme" } },
                new ProductFeature { Id = 2, Color = new List<Color> { Color.White, Color.Black, Color.Yellow,Color.Purple,Color.Beige }, Description = "30 derecede yıkayınız", ProductId = 2, Size = new List<Size> { Size.Small, Size.Medium,Size.Large,Size.XLarge }, Status = Core.Enums.Status.Added, PhotoUrl = new List<string> { "deneme", "deneme" } },
                new ProductFeature { Id = 3, Color = new List<Color> { Color.White, Color.Black, Color.Yellow,Color.Pink,Color.Brown }, Description = "30 derecede yıkayınız", ProductId = 3, Size = new List<Size> { Size.Small, Size.Large,Size.XLarge }, Status = Core.Enums.Status.Added, PhotoUrl = new List<string> { "deneme", "deneme" } },
                new ProductFeature { Id = 4, Color = new List<Color> { Color.White, Color.Black, Color.Yellow }, Description = "30 derecede yıkayınız", ProductId = 4, Size = new List<Size> { Size.Small,Size.Medium, Size.Large }, Status = Core.Enums.Status.Added, PhotoUrl = new List<string> { "deneme", "deneme" } },
                new ProductFeature { Id = 5, Color = new List<Color> { Color.White, Color.Black }, Description = "30 derecede yıkayınız", ProductId = 5, Size = new List<Size> { Size.Small, Size.XLarge }, Status = Core.Enums.Status.Added, PhotoUrl = new List<string> { "deneme", "deneme" } });
        }
    }
}
