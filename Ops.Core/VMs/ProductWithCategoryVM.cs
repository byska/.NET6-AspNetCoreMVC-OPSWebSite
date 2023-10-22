using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class ProductWithCategoryVM
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId{ get; set; }

    }
}
