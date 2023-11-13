using AutoMapper;
using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Core.UnitOfWorks;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Services
{
    public class CategoryService : Service<Category, CategoryCreateVM, CategoryVM>,ICategoryService
    {
        public CategoryService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }
    }
}
