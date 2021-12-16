using JPBlazor.Application.Interfaces.Repositories;
using JPBlazor.Domain.Entities.Misc;

namespace JPBlazor.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}