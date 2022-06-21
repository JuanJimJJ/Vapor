using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using VaporApp.Infrastructure.Persistance;
using System.Collections.Generic;
using System.Linq;

namespace VaporApp.Infrastructure.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private DBVaporContext _context;
        public CategoriesRepository(DBVaporContext context)
        {
            _context = context;
        }

        public IEnumerable<Categories> GetCategories()
        {
            return _context.Categories;
        }

        public Categories GetCategoriesById(int idCategories)
        {
            return _context.Categories.FirstOrDefault(x => x.IdCategory == idCategories);
        }

        public void InsertCategories(Categories categories)
        {
            _context.Categories.Add(categories);
            _context.SaveChanges();
        }

        public void UpdateCategories(Categories categories)
        {
            var categoryExisting = _context.Categories.FirstOrDefault(x => x.IdCategory == categories.IdCategory);
            categoryExisting.CategoryName = categories.CategoryName;
            _context.SaveChanges();
        }

        public void DeleteCategories(int idOrder)
        {
            var categoryExisting = _context.Categories.FirstOrDefault(x => x.IdCategory == idOrder);
            _context.Categories.Remove(categoryExisting);
            _context.SaveChanges();
        }
    }
}
