using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeProduct.Models.Product;
using MakeProduct.ViewModels.Product;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MakeProduct.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IWebHostEnvironment webHostEnvironment;

        public ProductController(IProductRepository productRepository, IWebHostEnvironment webHostEnvironment)
        {
            _productRepository = productRepository;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult List()
        {
            return View(_productRepository.GetAllProducts());
        }

        public IActionResult Detail(int id)
        {
            ProductDetailViewModel productDetailViewModel = new ProductDetailViewModel()
            {
                product = _productRepository.GetProduct(id),
                PageTitle = "產品細節"
            };

            return View(productDetailViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductCreateViewModel productCreateViewModel)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(productCreateViewModel);

                Product newProduct = new Product
                {
                    ProductName = productCreateViewModel.ProductName,
                    ProductClass = productCreateViewModel.ProductClass,
                    ProductCount = productCreateViewModel.ProductCount,
                    PhotoPath = uniqueFileName
                };

                _productRepository.Add(newProduct);

                return RedirectToAction("Detail", new { id = newProduct.Id });
            }

            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Product product = _productRepository.GetProduct(id);

            ProductEditViewModel productEditViewModel = new ProductEditViewModel()
            {
                Id = product.Id,
                ProductName = product.ProductName,
                ProductCount = product.ProductCount,
                ExistingPhotoPath = product.PhotoPath,
                ProductClass = product.ProductClass
            };

            return View(productEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(ProductEditViewModel productEditViewModel)
        {
            if (ModelState.IsValid)
            {
                Product product = _productRepository.GetProduct(productEditViewModel.Id);

                product.ProductName = productEditViewModel.ProductName;
                product.ProductCount = productEditViewModel.ProductCount;
                product.ProductClass = productEditViewModel.ProductClass;

                if (productEditViewModel.Photo != null)
                {
                    if (!string.IsNullOrWhiteSpace(productEditViewModel.ExistingPhotoPath))
                    {
                        string ExistingFilePath = Path.Combine(
                            webHostEnvironment.WebRootPath,
                            "images",
                            productEditViewModel.ExistingPhotoPath);

                        System.IO.File.Delete(ExistingFilePath);
                    }

                    product.PhotoPath = ProcessUploadedFile(productEditViewModel);
                }

                Product updateProduct = _productRepository.Update(product);

                return RedirectToAction("List");
            }

            return View(productEditViewModel);
        }

        /// <summary>
        /// 儲存圖片且回傳圖片名稱
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        private string ProcessUploadedFile(ProductCreateViewModel model)
        {
            string uniqueFileName = null;

            #region -- 多圖片 --
            //if (productCreateViewModel.Photo != null && productCreateViewModel.Photos.Count > 0)
            //{
            //    foreach (var Photo in productCreateViewModel.Photos)
            //    {
            //        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
            //        uniqueFileName = $"{Guid.NewGuid().ToString()}_{Photo.FileName}";
            //        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            //        Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            //    }
            //}
            #endregion

            if (model.Photo != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = $"{Guid.NewGuid().ToString()}_{model.Photo.FileName}";
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
