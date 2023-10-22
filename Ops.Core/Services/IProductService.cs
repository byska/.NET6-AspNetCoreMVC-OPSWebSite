using Ops.Core.Entities;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Services
{
    public interface IProductService : IService<Product,ProductCreateVM,ProductVM>
    {
        Task<List<ProductVM>> GetNewProductsAsync();
        Task<List<ProductVM>> GetBestsellerProductsAsync();
        Task<ProductsWithFeaturesVM> GetProductDetailsById(int id);
        Task<ProductWithCategoryVM> GetProductWithCategory(int id);
    }
}
