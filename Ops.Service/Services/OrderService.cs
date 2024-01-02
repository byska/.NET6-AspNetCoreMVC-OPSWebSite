using AutoMapper;
using Microsoft.AspNetCore.Http;
using Ops.Core.Entities;
using Ops.Core.Result.Abstract;
using Ops.Core.Result.Concrete;
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
        public async Task<IAppResult<OrderVM>> CreateOrder(IEnumerable<CartItemVM> cart, int userId)
        {
            Order order = new Order()
            {
                CustomerId = userId,
                TotalPrice = cart.Sum(x => x.TotalPrice+35)
            };
            var orderCreate = _mapper.Map<OrderCreateVM>(order);
            OrderVM orderVM = (await AddAsync(orderCreate)).Data;

            foreach (CartItemVM cartItemVM in cart)
            {
                ProductOrder productOrder = new ProductOrder()
                {
                    Amount = cartItemVM.Quantity,
                    ProductId = cartItemVM.ProductId,
                    OrderId = orderVM.OrderId

                };
                order.OrderProducts.Add(productOrder);
            }
            var orderUpdate = _mapper.Map<OrderCreateVM>(order);
            await UpdateAsync(orderUpdate);
            var orderReturnVM = _mapper.Map<OrderVM>(order);
            return AppResult<OrderVM>.Success(StatusCodes.Status200OK, orderReturnVM);
        }
    }
}
