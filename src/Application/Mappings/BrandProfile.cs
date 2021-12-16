using AutoMapper;
using JPBlazor.Application.Features.Brands.Commands.AddEdit;
using JPBlazor.Application.Features.Brands.Queries.GetAll;
using JPBlazor.Application.Features.Brands.Queries.GetById;
using JPBlazor.Domain.Entities.Catalog;

namespace JPBlazor.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}