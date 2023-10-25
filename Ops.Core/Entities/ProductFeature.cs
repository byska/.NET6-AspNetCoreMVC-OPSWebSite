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
        public ICollection<SizeProductFeature> SizeProductFeatures { get; set; }
        public ICollection<ColorProductFeature> ColorProductFeatures { get; set; }
        public string Description { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public ProductFeature()
        {
            Stocks=new HashSet<Stock>();
            SizeProductFeatures=new HashSet<SizeProductFeature>();
            ColorProductFeatures = new HashSet<ColorProductFeature>();
            Photos=new HashSet<Photo>();
        }
    }
}
