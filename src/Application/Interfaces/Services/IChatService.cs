using JPBlazor.Application.Responses.Identity;
using JPBlazor.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using JPBlazor.Application.Interfaces.Chat;
using JPBlazor.Application.Models.Chat;

namespace JPBlazor.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}