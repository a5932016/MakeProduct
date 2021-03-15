using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeProduct.Models.Product
{
    public class MockProductRepository : IProductRepository
    {
        private List<Product> _productList;

        public MockProductRepository()
        {
            _productList = new List<Product>()
            {
                new Product() { Id = 1, ProductName = "衣服", ProductCount = 10, ProductClass = ProductClassEnum.None },
                new Product() { Id = 2, ProductName = "褲子", ProductCount = 5, ProductClass = ProductClassEnum.Mobile },
                new Product() { Id = 3, ProductName = "鞋子", ProductCount = 8, ProductClass = ProductClassEnum.Vogue },
                new Product() { Id = 4, ProductName = "帽子", ProductCount = 8, ProductClass = ProductClassEnum.Beauty },
            };
        }

        public Product Add(Product product) 
        {
            product.Id = _productList.Max(s => s.Id) + 1;
            _productList.Add(product);
            return product;
        }

        public Product Delete(int id)
        {
            Product product = _productList.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                _productList.Remove(product);
            }

            return product;
        }

        public Product Update(Product updateProduct)
        {
            Product product = _productList.FirstOrDefault(p => p.Id == updateProduct.Id);

            if (product != null)
            {
                product.ProductName = updateProduct.ProductName;
                product.ProductCount = updateProduct.ProductCount;
                product.ProductClass = updateProduct.ProductClass;
                product.PhotoPath = updateProduct.PhotoPath;
            }

            return product;
        }

        public Product GetProduct(int id)
        {
            return _productList.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _productList;
        }
    }
}
