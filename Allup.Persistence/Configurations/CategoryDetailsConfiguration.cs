using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Allup.Persistence.Configurations;

internal class CategoryDetailsConfiguration : IEntityTypeConfiguration<CategoryDetails>
{
    public void Configure(EntityTypeBuilder<CategoryDetails> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

        builder.HasIndex(x => new { x.LanguageId, x.CategoryId }).IsUnique();
    }
}
