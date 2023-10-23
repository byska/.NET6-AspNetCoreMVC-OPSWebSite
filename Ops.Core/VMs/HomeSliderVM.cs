using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class HomeSliderVM
    {
        public string PhotoUrl { get; set; }
        public string? Title { get; set; }
        public string? Subtitle { get; set; }
        public int CategoryId { get; set; }
    }
}
