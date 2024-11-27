using Allup.Domain.Entities;

namespace Allup.Application.AutoMappers;

internal class LanguageAutoMapper : Profile
{
    public LanguageAutoMapper()
    {
        CreateMap<LanguageGetViewModel, Language>().ReverseMap();
    }
}

