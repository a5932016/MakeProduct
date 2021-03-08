using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeProduct.Models;

namespace MakeProduct.Models.Product
{
    public interface IProductRepository
    {
        public Product GetProduct(int id);

        public IEnumerable<Product> GetAllProducts();
    }
}
