using AutoMapper;
using Ops.Core.Entities;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductVM>()
                .ForMember(dest=>dest.PhotoUrl,opt=>opt.MapFrom(src=>src.ProductFeature/*.PhotoUrl*/))
            .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.ProductFeature/*.Color*/));
            CreateMap<Product, ProductsWithFeaturesVM>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.ProductFeature/*.PhotoUrl*/))
                .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.ProductFeature/*.Size*/))
                .ForMember(dest => dest.Color, opt => opt.MapFrom(src => src.ProductFeature/*.Color*/))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ProductFeature.Description));
            CreateMap<Comment, CommentVM>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Customer.FirstName+" "+src.Customer.LastName));
            CreateMap<Product, ProductWithCategoryVM>()
               .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Name));
        }
    }
}
