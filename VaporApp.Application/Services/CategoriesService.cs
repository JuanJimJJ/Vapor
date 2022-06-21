using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using VaporApp.Application.Interfaces;
using AutoMapper;
using VaporApp.Application.Responses;
using VaporApp.Application.Requests.Categories;
using VaporApp.Application.Requests;

namespace VaporApp.Application.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepository _repository;
        private readonly IMapper _mapper;
        public CategoriesService(ICategoriesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<CategoriesResponse> GetCategories()
        {
            var categories = _repository.GetCategories();
            var categoriesResponse = _mapper.Map<IEnumerable<CategoriesResponse>>(categories);
            return categoriesResponse;
        }

        public CategoriesResponse GetCategoriesById(int idCategory)
        {
            var categories = _repository.GetCategoriesById(idCategory);
            var categoriesResponse = _mapper.Map<CategoriesResponse>(categories);
            return categoriesResponse;
        }

        public void InsertCategories(CreateCategoriesRequest request)
        {
            var categories = _mapper.Map<Categories>(request);
            _repository.InsertCategories(categories);
        }

        public void UpdateCategories(UpdateCategoriesRequest categories)
        {
            var category = _mapper.Map<Categories>(categories);
            _repository.UpdateCategories(category);
        }

        public void DeleteCategories(int idCategory)
        {
            _repository.DeleteCategories(idCategory);
        }
    }
}
