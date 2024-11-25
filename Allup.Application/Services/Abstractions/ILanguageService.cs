namespace Allup.Application.Services.Abstractions;

public interface ILanguageService
{
    Task<List<LanguageGetViewModel>> GetLanguagesAsync();
    Task<LanguageGetViewModel> GetLanguageAsync(string isoCode);
}
