using AutoMapper;
using JPBlazor.Infrastructure.Models.Audit;
using JPBlazor.Application.Responses.Audit;

namespace JPBlazor.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}