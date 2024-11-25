using Allup.Domain.Entities;
using AutoMapper;

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
