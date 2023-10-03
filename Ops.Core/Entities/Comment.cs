namespace Ops.Core.Entities
{
    public class Comment : BaseEntity
    {
        public string Description { get; set; }
        public int Mark { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
