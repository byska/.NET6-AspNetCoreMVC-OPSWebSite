using Ops.Core.Entities;
using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs.AdminList
{
    public class OrderAdminVM
    {
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Taken;
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
