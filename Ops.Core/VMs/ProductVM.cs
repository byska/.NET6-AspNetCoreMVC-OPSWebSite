using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class ProductVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string> PhotoUrl { get; set; }
        public List<Color> Color { get; set; }

    }
}
