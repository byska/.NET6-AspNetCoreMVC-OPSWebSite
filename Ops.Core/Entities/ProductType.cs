using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class ProductType : BaseEntity
    {
        public ProductType()
        {
            Products = new HashSet<Product>();
        }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
