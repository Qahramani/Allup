namespace Allup.Domain.Entities;

public class SliderDetails : BaseEntity
{
    public string Title { get; set; } = null!;
    public string SubTitle { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int SliderId { get; set; }
    public Slider? Slider { get; set; }
    public int LanguageId { get; set; }
    public Language? Language { get; set; }
}