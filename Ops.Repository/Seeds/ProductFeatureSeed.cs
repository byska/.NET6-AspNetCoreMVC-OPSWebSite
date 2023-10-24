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
            builder.HasData(new ProductFeature { Id=1,  Description="30 derecede yıkayınız", ProductId=1, Status=Core.Enums.Status.Added, },
                new ProductFeature { Id = 2, Description = "30 derecede yıkayınız", ProductId = 2, Status = Core.Enums.Status.Added,  },
                new ProductFeature { Id = 3,  Description = "30 derecede yıkayınız", ProductId = 3, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 4,  Description = "30 derecede yıkayınız", ProductId = 4, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 5, Description = "30 derecede yıkayınız", ProductId = 5, Status = Core.Enums.Status.Added, });
        }
    }
}
