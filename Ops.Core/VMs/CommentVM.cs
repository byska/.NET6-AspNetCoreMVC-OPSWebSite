using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class CommentVM
    {
        public string Description { get; set; }
        public int Mark { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
    }
}
