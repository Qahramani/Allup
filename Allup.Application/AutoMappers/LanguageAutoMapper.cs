using Allup.Domain.Entities;

namespace Allup.Application.AutoMappers;

internal class LanguageAutoMapper : Profile
{
    public LanguageAutoMapper()
    {
        CreateMap<LanguageGetViewModel, Language>().ReverseMap();
    }
}

internal class CategoryAutoMapper : Profile
{
    public CategoryAutoMapper()
    {
        CreateMap<Category, CategoryGetViewModel>()
            .ForMember(dest => dest.Name, src => src.MapFrom(x => x.CategoryDetails.FirstOrDefault() != null ? x.CategoryDetails.FirstOrDefault()!.Name : ""));
    }
}
internal class ProductAutoMapper : Profile
{
    public ProductAutoMapper()
    {
        CreateMap<Product, ProductGetViewModel>()
            .ForMember(desc => desc.Name, src => src.MapFrom(x => x.ProductDetails.FirstOrDefault() != null ? x.ProductDetails.FirstOrDefault()!.Name : ""))
            .ForMember(desc => desc.Description, src => src.MapFrom(x => x.ProductDetails.FirstOrDefault() != null ? x.ProductDetails.FirstOrDefault()!.Description : ""))
            .ForMember(desc => desc.AdditionalImagesPaths, src => src.MapFrom(x => x.ProductImages.FirstOrDefault() != null ? x.ProductImages.FirstOrDefault()!.ImagePath : ""))
            .ForMember(desc => desc.CategoryName, src => src.MapFrom(x => x.Category.CategoryDetails.FirstOrDefault() != null ? x.Category.CategoryDetails.FirstOrDefault()!.Name : ""));
    }
}