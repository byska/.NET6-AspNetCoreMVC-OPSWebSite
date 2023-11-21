﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Seeds
{
    public class AdminSeed : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(new AppRole { Id = 1, Email = "orangepressstore@gmail.com", Password = "Beste1998.", FirstName = "Ayşe Nur", LastName = "Tabak", Status = Core.Enums.Status.Added });
        }
    }
}
