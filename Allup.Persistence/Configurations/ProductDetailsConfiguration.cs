using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Allup.Persistence.Configurations;

internal class ProductDetailsConfiguration : IEntityTypeConfiguration<ProductDetails>
{
    public void Configure(EntityTypeBuilder<ProductDetails> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasMaxLength(256);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(1024);

        builder.HasIndex(x => new { x.ProductId, x.LanguageId }).IsUnique();
    }
}