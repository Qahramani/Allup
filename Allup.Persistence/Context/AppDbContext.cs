
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Threading.Tasks.Sources;

namespace Allup.Persistence.Context;

public class AppDbContext : IdentityDbContext<AppUser>
{
    public AppDbContext(DbContextOptions options) : base(options)   
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.AddSeedData();

        base.OnModelCreating(builder);
    }
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<CategoryDetails> CategoryDetails { get; set; } = null!;
    public DbSet<Language> Languages { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<ProductDetails> ProductDetails { get; set; } = null!;
    public DbSet<ProductImage> ProductImages { get; set; } = null!;
    public DbSet<Slider> Sliders { get; set; } = null!;
    public DbSet<SliderDetails> SliderDetails { get; set; } = null!;
    public DbSet<Setting> Settings{ get; set; } = null!;
    public DbSet<SettingDetails> SettingDetails { get; set; } = null!;
    public DbSet<Service> Services { get; set; } = null!;
    public DbSet<ServiceDetails> ServiceDetails { get; set; } = null!;

}
