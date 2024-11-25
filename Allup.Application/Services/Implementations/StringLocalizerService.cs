using Microsoft.Extensions.Localization;

namespace Allup.Application.Services.Implementations;

public class StringLocalizerService
{
    private readonly IStringLocalizer _localizer;

    public StringLocalizerService(IStringLocalizerFactory localizerFactory)
    {
        _localizer = localizerFactory.Create("SharedResources","Allup.Presentation");
    }

    public string GetValue(string key)
    {
        return _localizer.GetString(key);   
    }
}
