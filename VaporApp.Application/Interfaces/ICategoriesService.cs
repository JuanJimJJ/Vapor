using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Application.Requests;
using VaporApp.Application.Requests.Categories;
using VaporApp.Application.Responses;

namespace VaporApp.Application.Interfaces
{
    public interface ICategoriesService
    {
        CategoriesResponse GetCategoriesById(int idCategory);
        IEnumerable<CategoriesResponse> GetCategories();

        void InsertCategories(CreateCategoriesRequest categories);

        void UpdateCategories(UpdateCategoriesRequest categories);

        void DeleteCategories(int idCategory);
    }
}
