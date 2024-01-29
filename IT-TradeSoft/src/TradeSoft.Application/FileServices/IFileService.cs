using Microsoft.AspNetCore.Http;
namespace TradeSoft.Application.FileServices
{
    public interface IFileService
    {
        public ValueTask<string> UploadImageAsync(IFormFile imagepath);
        public ValueTask<byte[]> GetImageAsync(string path);
        public ValueTask<string> UploadFileAsync(IFormFile filePath);
    }
}
