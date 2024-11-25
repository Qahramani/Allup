using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Allup.Persistence.Configurations;

internal class ServiceDetailsConfiguration : IEntityTypeConfiguration<ServiceDetails>
{
    public void Configure(EntityTypeBuilder<ServiceDetails> builder)
    {
        builder.Property(x => x.TopText).IsRequired().HasMaxLength(128);
        builder.Property(x => x.BottomText).IsRequired().HasMaxLength(128);

        builder.HasIndex(x => new { x.ServiceId, x.LanguageId }).IsUnique();

    }
}
