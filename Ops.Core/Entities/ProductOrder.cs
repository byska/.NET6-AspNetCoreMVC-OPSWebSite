using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class ProductOrder : BaseEntity
    {
        [ForeignKey("PRODUCTID")]
        public int? ProductId { get; set; }
        public Product? product { get; set; }
        [ForeignKey("ORDERID")]
        public int? OrderId { get; set; }
        public Order? order { get; set; }
        public int? Amount { get; set; }
    }
}
