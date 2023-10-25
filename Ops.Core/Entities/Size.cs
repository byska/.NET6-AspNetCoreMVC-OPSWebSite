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
        public ICollection<SizeProductFeature> SizeProductFeatures { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public Size()
        {
            SizeProductFeatures = new HashSet<SizeProductFeature>();
            Stocks=new HashSet<Stock>();
        }

    }
}
