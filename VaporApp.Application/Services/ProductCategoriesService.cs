using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using VaporApp.Application.Interfaces;
using AutoMapper;
using VaporApp.Application.Responses;
using VaporApp.Application.Requests.Users;
using VaporApp.Application.Requests;
using VaporApp.Application.Requests.ProductCategories;

namespace VaporApp.Application.Services
{
    public class ProductCategoriesService : IProductCategoriesService
    {
        private readonly IProductCategoriesRepository _repository;
        private readonly IMapper _mapper;
        public ProductCategoriesService(IProductCategoriesRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<ProductCategoriesResponse> GetProductCategories()
        {
            var productCategories = _repository.GetProductCategories();
            var productCategoriesResponse = _mapper.Map<IEnumerable<ProductCategoriesResponse>>(productCategories);
            return productCategoriesResponse;
        }

        public ProductCategoriesResponse GetProductCategoriesById(int idProductCategory)
        {
            var productCategories = _repository.GetProductCategoriesById(idProductCategory);
            var productCategoriesResponse = _mapper.Map<ProductCategoriesResponse>(productCategories);
            return productCategoriesResponse;
        }

        public void InsertProductCategories(CreateProductCategoriesRequest request)
        {
            var productCategories = _mapper.Map<ProductCategories>(request);
            _repository.InsertProductCategories(productCategories);
        }

        public void UpdateProductCategories(UpdateProductCategoriesRequest productCategories)
        {
            var productCategory = _mapper.Map<ProductCategories>(productCategories);
            _repository.UpdateProductCategories(productCategory);
        }

        public void DeleteProductCategories(int idProductCategory)
        {
            _repository.DeleteProductCategories(idProductCategory);
        }
    }
}
