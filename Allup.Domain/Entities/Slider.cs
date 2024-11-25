namespace Allup.Domain.Entities;

public class Slider : BaseEntity
{
    public string ImagePath { get; set; } = null!;
    public List<SliderDetails> SliderDetails { get; set; } = [];
}


