using Ops.Core.Entities;
using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class ProductsWithFeaturesVM:ProductVM
    {
        public List<string> Size { get; set; }
        public string Description { get; set; }
    }
}
