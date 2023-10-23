using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public  class Size:BaseEntity
    {
        public string Name { get; set; }
        public int ProductFeatureId { get; set; }
        public ProductFeature ProductFeature { get; set; }
       
    }
}
