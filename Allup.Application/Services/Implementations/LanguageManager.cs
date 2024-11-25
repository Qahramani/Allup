using Allup.Application.Services.Abstractions;
using Allup.Persistence.Repositories.Abstractions;


namespace Allup.Application.Services.Implementations;

public class LanguageManager : ILanguageService
{
    private readonly ILanguageRepository _languageRepository;
    private readonly IMapper _mapper;

    public LanguageManager(ILanguageRepository languageRepository, IMapper mapper)
    {
        _languageRepository = languageRepository;
        _mapper = mapper;
    }

    public async Task<LanguageGetViewModel> GetLanguageAsync(string isoCode)
    {
        var languages = _languageRepository.GetAll();

        var language = languages.FirstOrDefault(x => x.IsoCode.ToLower() == isoCode.ToLower());

        return _mapper.Map<LanguageGetViewModel>(language);
    }

    public async Task<List<LanguageGetViewModel>> GetLanguagesAsync()
    {
        var languages = _languageRepository.GetAll();
        var languagesViewModels = _mapper.Map<List<LanguageGetViewModel>>(languages);

        return languagesViewModels;
    }
}
