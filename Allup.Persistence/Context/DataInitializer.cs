using Allup.Domain.AppSettingsModels;
using Allup.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Allup.Persistence.Context;

public class DataInitializer
{
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly AppDbContext _appDbContext;
    private readonly IConfiguration _configuration;

    public DataInitializer(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, AppDbContext appDbContext, IConfiguration configuration)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _appDbContext = appDbContext;
        _configuration = configuration;
    }

    public async Task SeedDataAsync()
    {
        await _appDbContext.Database.MigrateAsync();

        await _createRoles();

        await _createSuperAdminAsync();
    }

    private async Task _createRoles()
    {
        var roles = Enum.GetNames(typeof(RoleType));

        foreach (var role in roles)
        {
            if (await _roleManager.FindByNameAsync(role) != null)
                continue;

            await _roleManager.CreateAsync(new IdentityRole(role));

        }
    }

    private async Task _createSuperAdminAsync()
    {
        var superAdmin = _configuration.GetSection("SuperAdmin").Get<SuperAdminOptions>();
        if (superAdmin == null)
            return;

        var isAlreadyExist = await _userManager.FindByNameAsync(superAdmin.Username);
        if(isAlreadyExist != null) return;

        var newAdminUser = new AppUser
        {
            UserName = superAdmin.Username,
            Fullname = superAdmin.Fullname,
            Email = superAdmin.Email
        };

        var result =  await _userManager.CreateAsync(newAdminUser,superAdmin.Password);
        if (!result.Succeeded)
            throw new Exception("User hasn't created");

        result = await _userManager.AddToRoleAsync(newAdminUser,nameof(RoleType.SuperAdmin));

        if(!result.Succeeded)
            throw new Exception("User can't assigned");
    }
}

