namespace Ops.Core.Entities
{
    public class City :BaseEntity
    {
        public City()
        {
            Customers = new HashSet<Customer>();
        }
        public string Name { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
