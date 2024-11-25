namespace Allup.Domain.Entities;

public class SettingDetails : BaseEntity
{
    public string Value { get; set; } = null!;
    public  int SettingId { get; set; }
    public Setting? Setting { get; set; }
    public int LanguageId { get; set; }
    public Language? Language { get; set; }
}


