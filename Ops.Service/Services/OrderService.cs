using AutoMapper;
using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Core.UnitOfWorks;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Services
{
    public class OrderService : Service<Order, OrderCreateVM, OrderVM>, IOrderService
    {
        public OrderService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }
    }
}
