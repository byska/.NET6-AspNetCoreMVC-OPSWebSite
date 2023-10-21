using Ops.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Entities
{
    public class ProductFeature :BaseEntity
    {
        public List<Size> Size { get; set; }
        public List<Color> Color { get; set; }
        public string Description { get; set; }
        public List<string> PhotoUrl { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
