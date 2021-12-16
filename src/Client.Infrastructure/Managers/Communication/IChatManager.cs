using JPBlazor.Application.Models.Chat;
using JPBlazor.Application.Responses.Identity;
using JPBlazor.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using JPBlazor.Application.Interfaces.Chat;

namespace JPBlazor.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}