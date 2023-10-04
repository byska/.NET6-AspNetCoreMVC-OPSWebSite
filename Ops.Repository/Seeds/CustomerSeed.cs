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
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(new Customer { Id = 1, DateOfBirth = new DateTime(16, 02, 1998), Email = "besteyasak@gmail.com", FirstName = "Beste", LastName = "Yasak", Password = "Beste1998.", PhoneNumber = "05362459825", Status = Core.Enums.Status.Added },
                            new Customer { Id = 2, DateOfBirth = new DateTime(06, 06, 1997), Email = "huseyingulerman.1997@gmail.com", FirstName = "Hüseyin", LastName = "Gülerman", Password = "Beste1998.", PhoneNumber = "05325841236", Status = Core.Enums.Status.Added });
        }
    }
}
