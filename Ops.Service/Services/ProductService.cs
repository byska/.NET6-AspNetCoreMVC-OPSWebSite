using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Ops.Core.Entities;
using Ops.Core.Repositories;
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
    public class ProductService : Service<Product,ProductCreateVM,ProductVM>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService( IUnitOfWork uow, IProductRepository productRepository, IMapper mapper) : base(uow,mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductVM>> GetBestsellerProductsAsync()
        {
            var product = await _productRepository.GetBestsellerProductsAsync();
            var productVm = _mapper.Map<List<ProductVM>>(product);
            return productVm;
        }

        public async Task<List<ProductVM>> GetNewProductsAsync()
        {
            var product = await _productRepository.GetNewProductsAsync();
            var productVm = _mapper.Map<List<ProductVM>>(product);
            return productVm;
        }

        public async Task<ProductsWithFeaturesVM> GetProductDetailsById(int id)
        {
          var productDetail= await _productRepository.GetAllByIncludeParametersAsync(x=>x.ProductFeature,x=>x.Id==id).FirstOrDefaultAsync();
            var productWithFeatureDto = _mapper.Map<ProductsWithFeaturesVM>(productDetail);
            return productWithFeatureDto;
        }
        public  async Task<ProductWithCategoryVM> GetProductWithCategory(int id) 
        {
            var product=await _productRepository.GetAllByIncludeParametersAsync(x=>x.Category,x=>x.Id==id).FirstOrDefaultAsync();
            var productWithCategory=_mapper.Map<ProductWithCategoryVM>(product);
            return productWithCategory;
        }
    }
}
