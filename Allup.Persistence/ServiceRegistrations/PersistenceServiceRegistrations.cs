using Allup.Persistence.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Allup.Persistence.ServiceRegistrations;

public static class PersistenceServiceRegistrations
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("AllupDbConnection"));
        });


        services.AddScoped<ILanguageRepository, LanguageRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ICategoryDetailsRepository, CategoryDetailsRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IProductDetailsRepository, ProductDetailsRepository>();
        services.AddScoped<IProductImageRepository, ProductImageRepository>();
        services.AddScoped<ISliderRepository, SliderRepository>();
        services.AddScoped<ISliderDetailsRepository, SliderDetailsRepository>();
        services.AddScoped<ISettingRepository, SettingRepository>();
        services.AddScoped<ISettingDetailsRepository, SettingDetailsRepository>();
        services.AddScoped<IServiceRepository, ServiceRepository>();
        services.AddScoped<IServiceDetailsRepository, ServiceDetailsRepository>();

        services.AddScoped<DataInitializer>();

        return services;
    }

}
