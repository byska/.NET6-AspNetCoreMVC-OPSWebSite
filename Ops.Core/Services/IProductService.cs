using Ops.Core.Entities;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<List<ProductVM>> GetNewProductsAsync();
        Task<List<ProductVM>> GetBestsellerProductsAsync();
    }
}
