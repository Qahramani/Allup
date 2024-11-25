﻿namespace Allup.Domain.Entities;

public class Category : BaseEntity
{
    public string? ImagePath { get; set; }
    public int? ParentId { get; set; }
    public Category? Parent { get; set; }
    public List<CategoryDetails> CategoryDetails { get; set; } = [];
    public List<Category> SubCategories { get; set; } = [];
}
