using Ops.Core.Entities;
using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class ProductsWithFeaturesVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string> Photos { get; set; }
        public List<string> Colors { get; set; }
        public int Stock { get; set; }
        public List<string> Size { get; set; }
        public string Description { get; set; }
    }
}
