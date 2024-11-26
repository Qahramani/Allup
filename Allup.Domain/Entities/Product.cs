namespace Allup.Domain.Entities;

public class Product : BaseEntity
{
    public string MainImagePath { get; set; } = null!;
    public string HoverImagePath { get; set; } = null!;
    public decimal Price { get; set; }
    public double Discount { get; set; }
    public double Rate { get; set; }
    public int Count { get; set; }
    public string? Code { get; set; }
    public int SalesCount { get; set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public List<ProductDetails> ProductDetails { get; set; } = [];
    public List<ProductImage> ProductImages { get; set; } = [];
}
