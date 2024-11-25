using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Allup.Persistence.Configurations;

internal class SliderDetailsConfiguration : IEntityTypeConfiguration<SliderDetails>
{
    public void Configure(EntityTypeBuilder<SliderDetails> builder)
    {
        builder.Property(x => x.Title).IsRequired().HasMaxLength(128);
        builder.Property(x => x.SubTitle).IsRequired().HasMaxLength(128);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(1024);

        builder.HasIndex(x => new { x.SliderId, x.LanguageId }).IsUnique();

    }
}
