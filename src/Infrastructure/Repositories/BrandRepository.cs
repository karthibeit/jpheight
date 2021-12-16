using JPBlazor.Application.Interfaces.Repositories;
using JPBlazor.Domain.Entities.Catalog;

namespace JPBlazor.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}