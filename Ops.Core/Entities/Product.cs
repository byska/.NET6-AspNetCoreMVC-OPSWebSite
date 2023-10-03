using Ops.Core.Enums;

namespace Ops.Core.Entities
{
    public class Product:BaseEntity
    {
        public Product()
        {
            Comments = new HashSet<Comment>();
        }
        public Size Size { get; set; }
        public string Description { get; set; }
        public ProductType productType { get; set; }
        public int productTypeId { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
