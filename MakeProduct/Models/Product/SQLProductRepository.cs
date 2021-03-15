using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MakeProduct.Models.Product
{
    public class SQLProductRepository : IProductRepository
    {
        private readonly AppDbContext conntext;

        public SQLProductRepository(AppDbContext conntext)
        {
            this.conntext = conntext;
        }

        public Product Add(Product product)
        {
            conntext.products.Add(product);
            conntext.SaveChanges();
            return product;
        }

        public Product Delete(int id)
        {
            Product product = conntext.products.Find(id);

            if (product != null)
            {
                conntext.products.Remove(product);
                conntext.SaveChanges();
            }

            return product;
        }

        public Product Update(Product updateProduct)
        {
            var product = conntext.products.Attach(updateProduct);
            product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            conntext.SaveChanges();

            return updateProduct;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return conntext.products.ToList();
        }

        public Product GetProduct(int id)
        {
            Product product = conntext.products.Find(id);
            return product;
        }
    }
}
