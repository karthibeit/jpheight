using AutoMapper;
using JPBlazor.Application.Features.DocumentTypes.Commands.AddEdit;
using JPBlazor.Application.Features.DocumentTypes.Queries.GetAll;
using JPBlazor.Application.Features.DocumentTypes.Queries.GetById;
using JPBlazor.Domain.Entities.Misc;

namespace JPBlazor.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}