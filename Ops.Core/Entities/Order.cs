using Ops.Core.Enums;

namespace Ops.Core.Entities
{
    public class Order : BaseEntity
    {
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Taken;
        public int CustomerId { get; set; }
        public AppUser Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
