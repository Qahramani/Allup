using Allup.Domain.Entities;

namespace Allup.Application.AutoMappers;

internal class ProductAutoMapper : Profile
{
    public ProductAutoMapper()
    {
        CreateMap<Product, ProductGetViewModel>()
            .ForMember(desc => desc.Name, src => src.MapFrom(x => x.ProductDetails.FirstOrDefault() != null ? x.ProductDetails.FirstOrDefault()!.Name : ""))
            .ForMember(desc => desc.Description, src => src.MapFrom(x => x.ProductDetails.FirstOrDefault() != null ? x.ProductDetails.FirstOrDefault()!.Description : ""))
            .ForMember(desc => desc.AdditionalImagesPaths, src => src.MapFrom(x => x.ProductImages.Select(x => x.ImagePath)))
            .ForMember(desc => desc.CategoryName, src => src.MapFrom(x => x.Category.CategoryDetails.FirstOrDefault() != null ? x.Category.CategoryDetails.FirstOrDefault()!.Name : ""));

        CreateMap<Product, WishlistItemGetViewModel>().ReverseMap();
    }
}