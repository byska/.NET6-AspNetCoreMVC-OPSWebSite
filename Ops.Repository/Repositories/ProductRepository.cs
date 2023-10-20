
using Microsoft.EntityFrameworkCore;
using Ops.Core.Entities;
using Ops.Core.Repositories;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetBestsellerProductsAsync()
        {
           return await _context.Products.OrderByDescending(x=>x.Amount).Include(x=>x.ProductFeature).Take(10).ToListAsync();
        }

        public async Task<List<Product>> GetNewProductsAsync()
        {
           return await _context.Products.OrderByDescending(x => x.CreatedDate).Include(x=>x.ProductFeature).Take(10).ToListAsync();
        }
    }
}
