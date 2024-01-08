using Ops.Core.Entities;
using Ops.Core.Repositories;
using Ops.Core.Result.Abstract;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }

        public Order UpdateOrder(Order order)
        {
            Order data = _context.Orders.Update(order).Entity;
            return data;

        }
    }
}
