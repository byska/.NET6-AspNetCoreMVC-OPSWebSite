namespace Ops.Core.Entities
{
    public class City :BaseEntity
    {
        public City()
        {
            Addresses = new HashSet<Address>();
            Counties = new HashSet<County>();

        }
        public string Name { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public ICollection<County>? Counties { get; set; }

    }
}
