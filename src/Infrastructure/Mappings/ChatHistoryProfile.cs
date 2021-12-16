using AutoMapper;
using JPBlazor.Application.Interfaces.Chat;
using JPBlazor.Application.Models.Chat;
using JPBlazor.Infrastructure.Models.Identity;

namespace JPBlazor.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}