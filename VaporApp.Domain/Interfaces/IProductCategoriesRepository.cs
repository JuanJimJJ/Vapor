using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Domain.Entities;

namespace VaporApp.Domain.Interfaces
{
    public interface IProductCategoriesRepository
    {
        ProductCategories GetProductCategoriesById(int idProductCategory);
        IEnumerable<ProductCategories> GetProductCategories();

        void InsertProductCategories(ProductCategories productCategory);

        void UpdateProductCategories(ProductCategories productCategory);

        void DeleteProductCategories(int idProductCategory);
    }
}
