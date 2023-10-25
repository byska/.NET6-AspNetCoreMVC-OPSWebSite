using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs.Create
{
    public class AddressCreateVM
    {
        public string Description { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
        public int CustomerId { get; set; }
    }
}
