using Allup.Domain.Entities;

namespace Allup.Application.AutoMappers;

internal class CategoryAutoMapper : Profile
{
    public CategoryAutoMapper()
    {
        CreateMap<Category, CategoryGetViewModel>()
            .ForMember(dest => dest.Name, src => src.MapFrom(x => x.CategoryDetails.FirstOrDefault() != null ? x.CategoryDetails.FirstOrDefault()!.Name : ""));
    }
}
