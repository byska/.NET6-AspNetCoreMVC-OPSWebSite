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
      
        public string Description { get; set; }
       
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public ProductFeature()
        {
            
        }
    }
}
