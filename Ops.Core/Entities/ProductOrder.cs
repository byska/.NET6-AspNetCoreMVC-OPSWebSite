using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class ProductOrder : BaseEntity
    {
        public int ProductId { get; set; }
        public Product product { get; set; }
        public int OrderId { get; set; }
        public Order order { get; set; }
    }
}
