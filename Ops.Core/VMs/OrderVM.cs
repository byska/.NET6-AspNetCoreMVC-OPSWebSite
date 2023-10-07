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
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Taken;
        public int ProductId { get; set; }
    }
}
