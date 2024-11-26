using Allup.Domain.Entities;

namespace Allup.Application.ViewModels;

public class ProductGetViewModel : IViewModel
{
    public int Id { get; set; }
    public string? Name { get; set; } 
    public string? Description { get; set; } 
    public string? MainImagePath { get; set; } 
    public string? HoverImagePath { get; set; }
    public decimal Price { get; set; }
    public double Discount { get; set; }
    public double Rate { get; set; }
    public int Count { get; set; }
    public string? Code { get; set; }
    public int SalesCount { get; set; }
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
   
    public List<string> AdditionalImagesPaths { get; set; } = [];

}
