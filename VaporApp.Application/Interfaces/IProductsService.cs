using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests;
using VaporApp.Application.Requests.Products;
using VaporApp.Application.Responses;

namespace VaporApp.Application.Interfaces
{
    public interface IProductsService
    {
        ProductsResponse GetProductsById(int idProduct);
        IEnumerable<ProductsResponse> GetProducts();

        void InsertProducts(CreateProductsRequest products);

        void UpdateProducts(UpdateProductsRequest products);

        void DeleteProducts(int idProduct);
    }
}
