using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class Customer:BaseUser
    {
        public Customer()
        {
            Comments = new HashSet<Comment>();
            Addresses = new HashSet<Address>();
            Orders = new HashSet<Order>();
        }
       public ICollection<Address> Addresses { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
