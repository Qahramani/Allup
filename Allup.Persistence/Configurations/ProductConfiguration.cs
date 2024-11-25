using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Allup.Persistence.Configurations;

internal class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(x => x.MainImagePath).IsRequired().HasMaxLength(256);
        builder.Property(x => x.HoverImagePath).IsRequired().HasMaxLength(256);
        builder.Property(x => x.Count).IsRequired();
        builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(8,2)");
        builder.Property(x => x.Code).IsRequired(false).HasMaxLength(128);
    }
}
