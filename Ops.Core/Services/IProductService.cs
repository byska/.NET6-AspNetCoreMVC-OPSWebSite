﻿using Ops.Core.Entities;
using Ops.Core.Result.Abstract;
using Ops.Core.VMs;
using Ops.Core.VMs.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Services
{
    public interface IProductService : IService<Product,ProductCreateVM,ProductVM>
    {
        Task<IAppResult<List<ProductVM>>> GetNewProductsAsync();
        Task<IAppResult<List<ProductVM>>> GetBestsellerProductsAsync();
        Task<ProductsWithFeaturesVM> GetProductDetailsById(int id);
        Task<ProductWithCategoryVM> GetProductWithCategory(int id);
        Task<IAppResult<List<ProductVM>>> GetProductsWithColorPhoto(int id);
    }
}
