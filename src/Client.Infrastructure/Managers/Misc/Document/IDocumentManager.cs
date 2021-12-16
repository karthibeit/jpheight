using JPBlazor.Application.Features.Documents.Commands.AddEdit;
using JPBlazor.Application.Features.Documents.Queries.GetAll;
using JPBlazor.Application.Requests.Documents;
using JPBlazor.Shared.Wrapper;
using System.Threading.Tasks;
using JPBlazor.Application.Features.Documents.Queries.GetById;

namespace JPBlazor.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}