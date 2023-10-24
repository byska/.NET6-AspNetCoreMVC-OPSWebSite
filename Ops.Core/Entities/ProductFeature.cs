using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class ProductFeature :BaseEntity
    {
        public ICollection<Size> Sizes { get; set; }
        public ICollection<Color> Colors { get; set; }
        public string Description { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public ProductFeature()
        {
            Stocks=new HashSet<Stock>();
            Sizes=new HashSet<Size>();
            Colors=new HashSet<Color>();
            Photos=new HashSet<Photo>();
        }
    }
}
