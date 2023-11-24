using Ops.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.VMs
{
    public class UserVM
    {
        public bool IsActive { get; set; } = true;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public List<string> Addresses { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
