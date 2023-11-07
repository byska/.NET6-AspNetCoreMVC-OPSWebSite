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
    public class MessageSeed : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasData(new Message { Name = "Beste", Email = "beyasak@hotmail.com", Subject = "Bilgi Alma", Description = "Fiziksel bir mağazanız bulunuyor mu acaba?" });
        }
    }
}
