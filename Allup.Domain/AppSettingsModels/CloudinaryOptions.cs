﻿namespace Allup.Domain.AppSettingsModels;

public class CloudinaryOptions
{
    public string APIKey { get; set; } = null!;
    public string APISecret { get; set; } = null!;
    public string CloudName { get; set; } = null!;
}