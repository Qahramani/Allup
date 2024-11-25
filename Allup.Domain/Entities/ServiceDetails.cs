namespace Allup.Domain.Entities;

public class ServiceDetails : BaseEntity
{
    public string TopText { get; set; } = null!;
    public string BottomText { get; set; } = null!;
    public int ServiceId { get; set; }
    public Service? Setting { get; set; }
    public int LanguageId { get; set; }
    public Language? Language { get; set; }
}


