using Microsoft.AspNetCore.Identity;
using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class AppUser:IdentityUser<int>
    {
        public AppUser()
        {
            Comments = new HashSet<Comment>();
            Addresses = new HashSet<Address>();
            Orders = new HashSet<Order>();
            UserName=Guid.NewGuid().ToString();
        }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public ICollection<Address> Addresses { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public bool PersonelDataProtection { get; set; }
        public bool MembershipAgreement { get; set; }

    }
}
