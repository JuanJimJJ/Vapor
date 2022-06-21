using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests;
using VaporApp.Application.Requests.ProductCategories;
using VaporApp.Application.Responses;

namespace VaporApp.Application.Interfaces
{
    public interface IProductCategoriesService
    {
        ProductCategoriesResponse GetProductCategoriesById(int idProductCategory);
        IEnumerable<ProductCategoriesResponse> GetProductCategories();

        void InsertProductCategories(CreateProductCategoriesRequest productCategories);

        void UpdateProductCategories(UpdateProductCategoriesRequest productCategories);

        void DeleteProductCategories(int idProductCategory);
    }
}
