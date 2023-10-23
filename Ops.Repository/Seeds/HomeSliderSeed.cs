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
    public class HomeSliderSeed : IEntityTypeConfiguration<HomeSlider>
    {
        public void Configure(EntityTypeBuilder<HomeSlider> builder)
        {
            builder.HasData(new HomeSlider { Id=1,Status=Core.Enums.Status.Added, PhotoUrl= "img/bg-img/bg-1.jpg", Title="Bahar Koleksiyonu",Subtitle="Eşsiz Bahar Koleksiyonumuza Bir Göz Gezdirin.",CategoryId=1},
            new HomeSlider { Id = 2, Status = Core.Enums.Status.Added, PhotoUrl = "img/bg-img/bg-2.jpg", Title = "Kargo Bedava", Subtitle = "29 Ekime Özel Kargo Bedava.",CategoryId=2 });
        }
    }
}
