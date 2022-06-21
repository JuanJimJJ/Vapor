using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using VaporApp.Application.Interfaces;
using AutoMapper;
using VaporApp.Application.Responses;
using VaporApp.Application.Requests;
using VaporApp.Application.Requests.Products;

namespace VaporApp.Application.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IProductsRepository _repository;
        private readonly IMapper _mapper;
        public ProductsService(IProductsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<ProductsResponse> GetProducts()
        {
            var products = _repository.GetProducts();
            var productsResponse = _mapper.Map<IEnumerable<ProductsResponse>>(products);
            return productsResponse;
        }

        public ProductsResponse GetProductsById(int idProduct)
        {
            var products = _repository.GetProductsById(idProduct);
            var productsResponse = _mapper.Map<ProductsResponse>(products);
            return productsResponse;
        }

        public void InsertProducts(CreateProductsRequest request)
        {
            var products = _mapper.Map<Products>(request);
            _repository.InsertProducts(products);
        }

        public void UpdateProducts(UpdateProductsRequest products)
        {
            var product = _mapper.Map<Products>(products);
            _repository.UpdateProducts(product);
        }

        public void DeleteProducts(int idProduct)
        {
            _repository.DeleteProducts(idProduct);
        }
    }
}
