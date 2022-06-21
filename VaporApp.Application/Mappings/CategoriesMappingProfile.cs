using AutoMapper;
using VaporApp.Application.Requests.Categories;
using VaporApp.Domain.Entities;
using VaporApp.Application.Responses;

namespace VaporApp.Application.Mappings
{
    internal class CategoriesMappingProfile : Profile
    {
        public CategoriesMappingProfile()
        {
            CreateMap<CreateCategoriesRequest, Categories>();
            CreateMap<Categories, CreateCategoriesRequest>();

            CreateMap<UpdateCategoriesRequest, Categories>();
            CreateMap<Categories, UpdateCategoriesRequest>();

            CreateMap<Categories, CategoriesResponse>();
        }
    }
}
