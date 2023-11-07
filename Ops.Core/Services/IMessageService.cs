using Ops.Core.Entities;
using Ops.Core.VMs.AdminList;
using Ops.Core.VMs.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Services
{
    public interface IMessageService: IService<Message, MessageCreateVM, MessageAdminVM>
    {
    }
}
