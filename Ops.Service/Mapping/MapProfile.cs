using AutoMapper;
using Ops.Core.Entities;
using Ops.Core.VMs;
using Ops.Core.VMs.AdminList;
using Ops.Core.VMs.Create;
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
                .ForMember(dest=>dest.Photo,opt=>opt.MapFrom(src=>src.Photos.FirstOrDefault().PhotoUrl))
            .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.ColorProducts.Select(x=>x.Color.Name.ToString()).ToList()));

            CreateMap<Product, ProductsWithFeaturesVM>()
                .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Photos.Select(x=>x.PhotoUrl).ToList()))
                .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments.Select(x => x.Description).ToList()))
                  .ForMember(dest => dest.CommentCustumerNames, opt => opt.MapFrom(src => src.Comments.Select(x => x.Customer.FirstName).ToList()))
                .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.SizeProducts.Select(x=>x.Size.Name).ToList()))
                .ForMember(dest => dest.Colors, opt => opt.MapFrom(src => src.ColorProducts.Select(x => x.Color.Name.ToString()).ToList()))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.ProductFeature.Description))
                .ForMember(dest => dest.Stock, opt => opt.MapFrom(src => src.Stock.Stocks));
            CreateMap<Comment, CommentVM>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Customer.FirstName+" "+src.Customer.LastName))
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name)); ;
            CreateMap<Product, ProductWithCategoryVM>()
               .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
               .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.Category.Id));
            CreateMap<HomeSlider,HomeSliderVM>();
            CreateMap<Size, SizeVM>();
            CreateMap<Color, ColorVM>();
            CreateMap<Category, CategoryVM>();
            CreateMap<MessageCreateVM, Message>();
            CreateMap<Message, MessageAdminVM>();
            CreateMap<UserCreateVM, AppUser>();
        }
    }
}
