namespace Allup.Domain.Entities;

public class Setting : BaseEntity
{
    public string Key { get; set; } = null!;
    public List<SettingDetails> SettingDetails { get; set; } = [];
}


