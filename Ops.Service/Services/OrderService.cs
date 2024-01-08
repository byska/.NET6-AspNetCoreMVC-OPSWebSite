using AutoMapper;
using Microsoft.AspNetCore.Http;
using Ops.Core.Entities;
using Ops.Core.Repositories;
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
        private readonly IOrderRepository _orderRepository;
        public OrderService(IUnitOfWork uow, IMapper mapper, IOrderRepository orderRepository) : base(uow, mapper)
        {
            _orderRepository = orderRepository;
        }
        public async Task<IAppResult<OrderVM>> CreateOrder(CartVM cart, int userId)
        {

            OrderCreateVM vm = new OrderCreateVM()
            {
                AddressId = cart.AddressId,
                CustomerId = userId,
                TotalPrice = cart.GrandTotal
            };
            OrderVM orderVM = (await AddAsync(vm)).Data;
            Order order = _mapper.Map<Order>(orderVM);
            foreach (CartItemVM cartItemVM in cart.CartItems)
            {

                ProductOrder productOrder = new ProductOrder()
                {
                    Amount = cartItemVM.Quantity,
                    ProductId = cartItemVM.ProductId,
                    OrderId = order.Id
                };
                order.OrderProducts.Add(productOrder);
            }
            Order data = _orderRepository.UpdateOrder(order);
            var orderReturnVM = _mapper.Map<OrderVM>(data);
            return AppResult<OrderVM>.Success(StatusCodes.Status200OK, orderReturnVM);
        }
    }
}
