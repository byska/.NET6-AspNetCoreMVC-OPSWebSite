using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class District : BaseEntity
    {
        public District()
        {
            Addresses = new HashSet<Address>();
        }
        public string Name { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public ICollection<Address>? Addresses { get; set; }
    }
}
