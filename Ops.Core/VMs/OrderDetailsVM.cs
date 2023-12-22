using Ops.Core.Entities;
using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class OrderDetailsVM
    {
        public OrderStatus OrderStatus { get; set; }
        public List<ProductOrder> Products { get; set; }
        public int? Amount { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string RecipientName { get; set; }
        public Address Address { get; set; }
        public string? ShipCode { get; set; }
        public decimal Price { get; set; }

    }
}
