using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class County : BaseEntity
    {
        public County()
        {
            Addresses = new HashSet<Address>();
        }
        public string Name { get; set; }
        public ICollection<Address>? Addresses { get; set; }
    }
}
