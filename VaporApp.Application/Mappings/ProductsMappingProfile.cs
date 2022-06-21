using AutoMapper;
using VaporApp.Application.Requests.Products;
using VaporApp.Application.Responses;
using VaporApp.Domain.Entities;

namespace VaporApp.Application.Mappings
{
    public class ProductsMappingProfile : Profile
    {
        public ProductsMappingProfile()
        {
            CreateMap<CreateProductsRequest, Products>();
            CreateMap<Products, CreateProductsRequest>();

            CreateMap<UpdateProductsRequest, Products>();
            CreateMap<Products, UpdateProductsRequest>();

            CreateMap<Products, ProductsResponse>();
        }
    }
}
