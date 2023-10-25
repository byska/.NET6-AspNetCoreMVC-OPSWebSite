using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Core.VMs.Create;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ops.Core.UnitOfWorks;
using AutoMapper;

namespace Ops.Service.Services
{
    public class SizeService : Service<Size, SizeCreateVM, SizeVM>, ISizeService
    {
        public SizeService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }
    }
}
