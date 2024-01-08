using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class Address :BaseEntity
    {
        public Address()
        {
            Orders= new HashSet<Order>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public string ZIP { get; set; }
        public County County { get; set; }
        public int CountyId { get; set; }
        public AppUser Customer { get; set; }
        public int CustomerId { get; set; } 
        public ICollection<Order> Orders { get; set; }
        
    }
}
