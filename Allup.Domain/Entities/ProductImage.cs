namespace Allup.Domain.Entities;

public class ProductImage : BaseEntity
{
    public string ImagePath { get; set; } = null!;
    public int ProductId { get; set; }
    public Product? Product { get; set; }
}