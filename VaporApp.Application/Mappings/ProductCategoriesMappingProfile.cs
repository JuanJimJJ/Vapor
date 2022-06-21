using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests.ProductCategories;
using VaporApp.Domain.Entities;
using VaporApp.Application.Responses;

namespace VaporApp.Application.Mappings
{
    class ProductCategoriesMappingProfile : Profile
    {
        public ProductCategoriesMappingProfile()
        {
            CreateMap<CreateProductCategoriesRequest, ProductCategories>();
            CreateMap<ProductCategories, CreateProductCategoriesRequest>();

            CreateMap<UpdateProductCategoriesRequest, ProductCategories>();
            CreateMap<ProductCategories, UpdateProductCategoriesRequest>();

            CreateMap<ProductCategories, ProductCategoriesResponse>();
        }
    }
}
