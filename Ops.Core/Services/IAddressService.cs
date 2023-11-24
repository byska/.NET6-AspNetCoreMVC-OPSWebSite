using Ops.Core.VMs.Create;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ops.Core.Entities;

namespace Ops.Core.Services
{
    public interface IAddressService : IService<Address, AddressCreateVM, AddressVM>
    {
    }
}
