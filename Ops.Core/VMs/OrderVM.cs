using Ops.Core.Entities;
using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class OrderVM
    {
        public OrderStatus OrderStatus { get; set; }
        public List<int> ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string RecipientName { get; set; }

    }
}
