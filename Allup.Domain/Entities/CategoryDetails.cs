namespace Allup.Domain.Entities;

public class CategoryDetails: BaseEntity
{
    public string Name { get; set; } = null!;
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public int LanguageId { get; set; }
    public Language? Language { get; set; }
}
