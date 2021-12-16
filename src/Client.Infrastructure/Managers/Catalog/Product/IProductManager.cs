﻿using JPBlazor.Application.Features.Products.Commands.AddEdit;
using JPBlazor.Application.Features.Products.Queries.GetAllPaged;
using JPBlazor.Application.Requests.Catalog;
using JPBlazor.Shared.Wrapper;
using System.Threading.Tasks;

namespace JPBlazor.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}