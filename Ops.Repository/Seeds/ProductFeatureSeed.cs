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
                new ProductFeature { Id = 5, Description = "30 derecede yıkayınız", ProductId = 5, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 6, Description = "30 derecede yıkayınız", ProductId = 6, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 7, Description = "30 derecede yıkayınız", ProductId = 7, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 8, Description = "30 derecede yıkayınız", ProductId = 8, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 9, Description = "30 derecede yıkayınız", ProductId = 9, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 10, Description = "30 derecede yıkayınız", ProductId = 10, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 11, Description = "30 derecede yıkayınız", ProductId = 11, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 12, Description = "30 derecede yıkayınız", ProductId = 12, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 13, Description = "30 derecede yıkayınız", ProductId = 13, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 14, Description = "30 derecede yıkayınız", ProductId = 14, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 15, Description = "30 derecede yıkayınız", ProductId = 15, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 16, Description = "30 derecede yıkayınız", ProductId = 16, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 17, Description = "30 derecede yıkayınız", ProductId = 17, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 18, Description = "30 derecede yıkayınız", ProductId = 18, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 19, Description = "30 derecede yıkayınız", ProductId = 19, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 20, Description = "30 derecede yıkayınız", ProductId = 20, Status = Core.Enums.Status.Added, },
                new ProductFeature { Id = 21, Description = "30 derecede yıkayınız", ProductId = 21, Status = Core.Enums.Status.Added, });
        }
    }
}
