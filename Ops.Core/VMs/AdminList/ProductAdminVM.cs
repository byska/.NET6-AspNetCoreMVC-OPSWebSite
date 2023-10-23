using Ops.Core.Entities;
using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs.AdminList
{
    public class ProductAdminVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Amount { get; set; }
        public List<string> PhotoUrl { get; set; }
        public List<Color> Color { get; set; }
        public List<Size> Size { get; set; }
        public string Description { get; set; }

    }
}
