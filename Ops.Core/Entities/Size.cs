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
        public ICollection<SizeProduct> SizeProducts { get; set; }
        public Stock Stock { get; set; }
        public Size()
        {
            SizeProducts = new HashSet<SizeProduct>();
        }

    }
}
