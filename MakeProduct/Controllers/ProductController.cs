using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeProduct.Models.Product;
using MakeProduct.ViewModels.Product;

namespace MakeProduct.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult ProductList()
        {
            return View(_productRepository.GetAllProducts());
        }

        public IActionResult ProductDetail(int id)
        {
            ProductDetailViewModel productDetailViewModel = new ProductDetailViewModel()
            {
                product = _productRepository.GetProduct(id),
                PageTitle = "產品細節"
            };

            return View(productDetailViewModel);
        }
    }
}
