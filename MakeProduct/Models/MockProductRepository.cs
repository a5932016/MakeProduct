using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeProduct.Models.Product
{
    public class MockProductRepository : IProductRepository
    {
        private IEnumerable<Product> _products;

        public MockProductRepository()
        {
            _products = new List<Product>()
            {
                new Product() { Id = 1, ProductName = "衣服", ProductCount = 10 },
                new Product() { Id = 2, ProductName = "褲子", ProductCount = 5 },
                new Product() { Id = 3, ProductName = "鞋子", ProductCount = 8 }
            };
        }

        public Product GetProduct(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
