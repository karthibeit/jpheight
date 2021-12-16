using AutoMapper;
using JPBlazor.Application.Features.Products.Commands.AddEdit;
using JPBlazor.Domain.Entities.Catalog;

namespace JPBlazor.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}