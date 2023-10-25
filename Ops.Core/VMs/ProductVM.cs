using Ops.Core.Entities;


namespace Ops.Core.VMs
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<string> Photos { get; set; }
        public List<string> Colors { get; set; }

    }
}
