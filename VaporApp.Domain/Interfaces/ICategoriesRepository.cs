using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Domain.Entities;

namespace VaporApp.Domain.Interfaces
{
    public interface ICategoriesRepository
    {
        Categories GetCategoriesById(int idCategory);
        IEnumerable<Categories> GetCategories();

        void InsertCategories(Categories categories);

        void UpdateCategories(Categories categories);

        void DeleteCategories(int idCategory);
    }
}
