using Ops.Core.Entities;
using Ops.Core.Result.Abstract;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Order UpdateOrder(Order order);
    }
}
