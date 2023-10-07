using Ops.Core.Enums;

namespace Ops.Core.VMs.Create
{
    public class ProductFeatureCreateVM
    {
        public Size Size { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }

        public int ProductId { get; set; }
    }
}
