using JPBlazor.Application.Interfaces.Common;

namespace JPBlazor.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}