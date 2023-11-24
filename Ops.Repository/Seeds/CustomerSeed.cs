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
    public class CustomerSeed : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(new AppUser { Id = 1, DateOfBirth = new DateTime(1998, 02, 16), Email = "besteyasak@gmail.com", FirstName = "Beste", LastName = "Yasak", PasswordHash = "Beste1998.", PhoneNumber = "05362459825", Status = Core.Enums.Status.Added },
                            new AppUser { Id = 2, DateOfBirth = new DateTime(1997, 06, 06), Email = "huseyingulerman.1997@gmail.com", FirstName = "Hüseyin", LastName = "Gülerman", PasswordHash = "Beste1998.", PhoneNumber = "05325841236", Status = Core.Enums.Status.Added },
                            new AppUser { Id = 3, DateOfBirth = new DateTime(1997, 05, 17), Email = "orangepressstore@gmail.com", FirstName = "Ayşe", LastName = "Tabak", PasswordHash = "Beste1998.", PhoneNumber = "05325841236", Status = Core.Enums.Status.Added } );
        }
    }
}
