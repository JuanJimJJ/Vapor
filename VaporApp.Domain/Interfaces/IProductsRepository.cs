using System;
using System.Collections.Generic;
using System.Text;
using VaporApp.Domain.Entities;

namespace VaporApp.Domain.Interfaces
{
    public interface IProductsRepository
    {
        Products GetProductsById(int idProduct);
        IEnumerable<Products> GetProducts();

        void InsertProducts(Products products);

        void UpdateProducts(Products products);

        void DeleteProducts(int idProduct);
    }
}
