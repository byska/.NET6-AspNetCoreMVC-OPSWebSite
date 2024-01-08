using Ops.Core.Enums;

namespace Ops.Core.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {
            OrderProducts = new HashSet<ProductOrder>();
        }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Taken;
        public int? CustomerId { get; set; }
        public AppUser Customer { get; set; }
        public ICollection<ProductOrder>? OrderProducts { get; set; }
        public decimal TotalPrice { get; set; }
        public string? ShipCode { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
