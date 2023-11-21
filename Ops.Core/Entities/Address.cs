using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class Address :BaseEntity
    {
        public string Description { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public County County { get; set; }
        public int CountyId { get; set; }
        public AppUser Customer { get; set; }
        public int CustomerId { get; set; } 
    }
}
