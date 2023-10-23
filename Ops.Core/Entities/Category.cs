using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
                Products=new HashSet<Product>();
                HomeSliders=new HashSet<HomeSlider>();
        }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<HomeSlider> HomeSliders { get; set; }

    }
}
