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
        }
        public string Address { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public County County { get; set; }
        public int CountyId { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
