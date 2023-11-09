
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

        //public async Task<Product> GetProductDetailsById(int id)
        //{
        //    return await _context.Products.Include(x => x.ProductFeature).FirstOrDefaultAsync(x=>x.Id== id);
        //}
        public async Task<List<Product>> GetProductsWithColorPhotos(int id)
        {
           return await _context.Products.Include(x=>x.Photos).Include(x => x.ColorProducts).ThenInclude(x => x.Color).Where(x=>x.CategoryId==id).ToListAsync();
        }
        public async Task<Product> GetProductDetailsById(int id)
        {
            return await _context.Products.Include(x => x.Stock).Include(x=>x.ProductFeature).Include(x => x.SizeProducts).ThenInclude(x => x.Size).Include(x => x.Photos).Include(x => x.ColorProducts).ThenInclude(x => x.Color).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
