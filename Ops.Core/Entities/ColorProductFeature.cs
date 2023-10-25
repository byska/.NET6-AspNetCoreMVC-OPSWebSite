using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class ColorProductFeature:BaseEntity
    {
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int ProductFeatureId { get; set; }
        public ProductFeature   ProductFeature { get; set; }
    }
}
