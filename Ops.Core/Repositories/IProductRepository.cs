﻿using Ops.Core.Entities;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Repositories
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        Task<List<Product>> GetNewProductsAsync();
        Task<List<Product>> GetBestsellerProductsAsync();

        //Task<Product> GetProductDetailsById(int id);
    }
}
