namespace Ops.Core.Entities
{
    public class City :BaseEntity
    {
        public City()
        {
            Addresses = new HashSet<Address>();
            Districts = new List<District>();

        }
        public string Name { get; set; }
        public ICollection<Address>? Addresses { get; set; }
        public List<District>? Districts { get; set; }


    }
}
