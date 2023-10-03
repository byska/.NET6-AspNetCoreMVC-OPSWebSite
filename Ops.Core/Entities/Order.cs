using Ops.Core.Enums;

namespace Ops.Core.Entities
{
    public class Order : BaseEntity
    {
        public OrderStatus OrderStatus { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
