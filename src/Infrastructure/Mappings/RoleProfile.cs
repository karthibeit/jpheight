using AutoMapper;
using JPBlazor.Infrastructure.Models.Identity;
using JPBlazor.Application.Responses.Identity;

namespace JPBlazor.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}