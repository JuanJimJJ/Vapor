using VaporApp.Domain.Entities;
using VaporApp.Domain.Interfaces;
using VaporApp.Infrastructure.Persistance;
using System.Collections.Generic;
using System.Linq;

namespace VaporApp.Infrastructure.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private DBVaporContext _context;
        public ProductsRepository(DBVaporContext context)
        {
            _context = context;
        }

        public IEnumerable<Products> GetProducts()
        {
            return _context.Products;
        }

        public Products GetProductsById(int idProduct)
        {
            return _context.Products.FirstOrDefault(x => x.IdProduct == idProduct);
        }

        public void InsertProducts(Products products)
        {
            _context.Products.Add(products);
            _context.SaveChanges();
        }

        public void UpdateProducts(Products products)
        {
            var productExisting = _context.Products.FirstOrDefault(x => x.IdProduct == products.IdProduct);
            productExisting.ProductName = products.ProductName;
            productExisting.ProductReview = products.ProductReview;
            productExisting.ProductSku = products.ProductSku;
            productExisting.ProductStock = products.ProductStock;
            productExisting.ProductPrice = products.ProductPrice;
            _context.SaveChanges();
        }

        public void DeleteProducts(int idProduct)
        {
            var productExisting = _context.Products.FirstOrDefault(x => x.IdProduct == idProduct);
            _context.Products.Remove(productExisting);
            _context.SaveChanges();
        }
    }
}
