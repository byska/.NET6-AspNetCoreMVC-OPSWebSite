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
                .ForMember(dest=>dest.Photos,opt=>opt.MapFrom(src=>src.Photos.Select(cfg=>cfg.PhotoUrl)))
            .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.ColorProducts.Select(cfg=>cfg.Color.Name)));

            CreateMap<Product, ProductsWithFeaturesVM>()
                .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Photos.Select(x=>x.PhotoUrl)))
                .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.SizeProducts.Select(x=>x.Size.Name)))
                .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.ColorProducts.Select(x=>x.Color.Name)))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ProductFeature.Description));
            CreateMap<Comment, CommentVM>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Customer.FirstName+" "+src.Customer.LastName));
            CreateMap<Product, ProductWithCategoryVM>()
               .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
               .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.Id));
            CreateMap<HomeSlider,HomeSliderVM>();
            CreateMap<Size, SizeVM>();
            CreateMap<Color, ColorVM>();
        }
    }
}
