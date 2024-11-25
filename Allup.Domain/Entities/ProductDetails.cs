namespace Allup.Domain.Entities;

public class ProductDetails : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int LanguageId { get; set; }
    public Language? Language { get; set; }
}
