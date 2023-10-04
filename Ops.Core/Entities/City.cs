namespace Ops.Core.Entities
{
    public class City :BaseEntity
    {
        public City()
        {
            Addresses = new HashSet<Address>();
        }
        public string Name { get; set; }
        public ICollection<Address>? Addresses { get; set; }
    }
}
