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
            Customers = new HashSet<Customer>();
        }
        public string Name { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
