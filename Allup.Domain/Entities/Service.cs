namespace Allup.Domain.Entities;

public class Service : BaseEntity
{
    public string Icon { get; set; } = null!;
    public List<ServiceDetails> ServiceDetails { get; set; } = [];
}


