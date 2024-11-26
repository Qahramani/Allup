using Microsoft.AspNetCore.Http;

namespace Allup.Application.Helpers.Abstractions;

public interface ICloudinaryService 
{
    Task<bool> FileDeleteAsync(string filePath);
    Task<string> FileCreateAsync(IFormFile file);
}
