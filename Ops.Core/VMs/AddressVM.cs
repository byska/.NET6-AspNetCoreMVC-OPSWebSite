using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class AddressVM
    {
        public string Description { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
    }
}
