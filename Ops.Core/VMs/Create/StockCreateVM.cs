using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs.Create
{
    public class StockCreateVM
    {
        public int Stocks { get; set; }
        public int ProductFeatureId { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }
    }
}
