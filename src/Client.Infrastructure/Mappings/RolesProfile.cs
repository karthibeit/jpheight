using AutoMapper;
using JPBlazor.Application.Requests.Identity;
using JPBlazor.Application.Responses.Identity;

namespace JPBlazor.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}