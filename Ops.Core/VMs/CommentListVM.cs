using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class CommentListVM
    {
        public int Id { get; set; }
        public List<CommentVM> Comments { get; set; }
    }
}
