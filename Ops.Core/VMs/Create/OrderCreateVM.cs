using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs.Create
{
    public class OrderCreateVM
    {
        public List<int> ProductId { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
    }
}
