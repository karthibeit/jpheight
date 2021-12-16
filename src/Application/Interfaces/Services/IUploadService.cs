using JPBlazor.Application.Requests;

namespace JPBlazor.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}