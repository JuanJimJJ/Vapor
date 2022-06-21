using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using VaporApp.Infrastructure.Persistance;
using System.Collections.Generic;
using System.Linq;

namespace VaporApp.Infrastructure.Repositories
{
    public class ProductCategoriesRepository : IProductCategoriesRepository
    {
        private DBVaporContext _context;
        public ProductCategoriesRepository(DBVaporContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductCategories> GetProductCategories()
        {
            return _context.ProductCategories;
        }

        public ProductCategories GetProductCategoriesById(int idProductCategory)
        {
            return _context.ProductCategories.FirstOrDefault(x => x.IdProductCategory == idProductCategory);
        }

        public void InsertProductCategories(ProductCategories productCategories)
        {
            _context.ProductCategories.Add(productCategories);
            _context.SaveChanges();
        }

        public void UpdateProductCategories(ProductCategories productCategories)
        {
            var productCategoryExisting = _context.ProductCategories.FirstOrDefault(x => x.IdProductCategory == productCategories.IdProductCategory);
            productCategoryExisting.IdProductCategory = productCategoryExisting.IdProductCategory;
            _context.SaveChanges();
        }

        public void DeleteProductCategories(int idProductCategory)
        {
            var productCategoryExisting = _context.ProductCategories.FirstOrDefault(x => x.IdProductCategory == idProductCategory);
            _context.ProductCategories.Remove(productCategoryExisting);
            _context.SaveChanges();
        }
    }
}
