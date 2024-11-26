using Allup.Application.Helpers;
using Allup.Application.Helpers.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;

namespace Allup.Application.ServiceRegistrations;

public static class ApplicationServiceRegistrations
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.Configure<RequestLocalizationOptions>(options =>
        {
            var suportedCultures = new List<CultureInfo>
            {
                new CultureInfo("en-US"),
                new CultureInfo("az")
            };
            options.DefaultRequestCulture = new RequestCulture(culture: "en-US", uiCulture: "en-US");
            options.SupportedCultures = suportedCultures;
            options.SupportedUICultures = suportedCultures;
        });

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddScoped<ILanguageService, LanguageManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<IProductService, ProductManager>();

        services.AddScoped<IHomeService, HomeManager>();
        services.AddScoped<ILayoutService, LayoutManager>();

        services.AddScoped<ICloudinaryService, CloudinaryManager>();

        services.AddSingleton<StringLocalizerService>();

        return services;
    }
}
