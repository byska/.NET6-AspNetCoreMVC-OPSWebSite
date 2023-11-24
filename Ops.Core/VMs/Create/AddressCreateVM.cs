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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public int ZIP { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
        public int CustomerId { get; set; }
    }
}
