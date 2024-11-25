using Microsoft.EntityFrameworkCore;

namespace Allup.Persistence.Context;

internal static class SeedDataService
{
    public static void AddSeedData(this ModelBuilder builder)
    {
        builder.addLanguges();
    }

    private static void addLanguges(this ModelBuilder builder)
    {
        Language language1 = new() { Id = 1 , Name = "Azerbaijan", IsoCode= "az", ImagePath = "" };
        Language language2 = new() { Id = 2 , Name = "English", IsoCode= "en-us", ImagePath = "" };

        List<Language> languages = [language1, language2];

        builder.Entity<Language>().HasData(languages);
    }
}
