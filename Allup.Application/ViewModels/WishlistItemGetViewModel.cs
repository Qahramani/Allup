using Allup.Domain.Entities;

namespace Allup.Application.ViewModels;

public class WishlistItemGetViewModel : IViewModel
{
    public int Id { get; set; }
    public string? MainImagePath { get; set; }
    public decimal Price { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}
