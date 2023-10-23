using Ops.Core.Entities;
using Ops.Core.Enums;

namespace Ops.Core.VMs.Create
{
    public class ProductFeatureCreateVM
    {
        public List<Size> Size { get; set; }
        public List<Color> Color { get; set; }
        public string Description { get; set; }
        public List<string> PhotoUrl { get; set; }
        public int ProductId { get; set; }
    }
}
