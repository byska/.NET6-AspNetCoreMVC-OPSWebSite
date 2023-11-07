using Ops.Core.Services;
using Ops.Core.VMs.Create;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ops.Core.Entities;
using Ops.Core.VMs.AdminList;
using Ops.Core.UnitOfWorks;
using AutoMapper;

namespace Ops.Service.Services
{
    public class MessageService : Service<Message, MessageCreateVM, MessageAdminVM>, IMessageService
    {
        public MessageService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }
    }
}
