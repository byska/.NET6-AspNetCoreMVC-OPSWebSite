using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class Color : BaseEntity
    {
        public string Name { get; set; }
      
        public ICollection<ColorProductFeature> ColorProductFeatures{ get; set; }
        public ICollection<Photo>  Photos { get; set; }     
        public ICollection<Stock> Stocks { get; set; }
        public Color()
        {
          ColorProductFeatures = new HashSet<ColorProductFeature>();
            Stocks=new HashSet<Stock>();
        }

    }
}
