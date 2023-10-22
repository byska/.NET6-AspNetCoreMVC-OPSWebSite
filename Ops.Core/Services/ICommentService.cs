using Ops.Core.Entities;
using Ops.Core.VMs.Create;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Services
{
    public interface ICommentService : IService<Comment, CommentCreateVM, CommentVM>
    {
    }
}
