using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeProduct.Models;

namespace MakeProduct.Models.Product
{
    public interface IProductRepository
    {
        /// <summary>
        /// 通過ID來獲取產品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetProduct(int id);

        /// <summary>
        /// 取得所有產品資料
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetAllProducts();

        /// <summary>
        /// 新增一個產品
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public Product Add(Product product);

        /// <summary>
        /// 修改一個產品
        /// </summary>
        /// <param name="updateProduct"></param>
        /// <returns></returns>
        public Product Update(Product updateProduct);

        /// <summary>
        /// 刪除一個產品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product Delete(int id);
    }
}
