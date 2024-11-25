using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Allup.Persistence.Configurations;

internal class SettingDetailsConfiguration : IEntityTypeConfiguration<SettingDetails>
{
    public void Configure(EntityTypeBuilder<SettingDetails> builder)
    {
        builder.Property(x => x.Value).IsRequired().HasMaxLength(1024);

        builder.HasIndex(x => new { x.SettingId, x.LanguageId }).IsUnique();

    }
}