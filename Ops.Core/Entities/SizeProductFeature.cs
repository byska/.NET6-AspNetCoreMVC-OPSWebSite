using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class SizeProductFeature:BaseEntity
    {
        public int ProductFeatureId { get; set; }
        public ProductFeature ProductFeature { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
    }
}
