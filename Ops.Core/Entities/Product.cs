using Ops.Core.Enums;

namespace Ops.Core.Entities
{
    public class Product:BaseEntity
    {
        public Product()
        {
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int? Amount { get; set; }



        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public ProductFeature ProductFeature { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
