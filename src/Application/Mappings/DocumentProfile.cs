using AutoMapper;
using JPBlazor.Application.Features.Documents.Commands.AddEdit;
using JPBlazor.Application.Features.Documents.Queries.GetById;
using JPBlazor.Domain.Entities.Misc;

namespace JPBlazor.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}