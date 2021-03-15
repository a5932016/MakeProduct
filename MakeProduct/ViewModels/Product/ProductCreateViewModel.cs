using MakeProduct.Models.Product;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MakeProduct.ViewModels.Product
{
    public class ProductCreateViewModel
    {
        [Display(Name = "產品名稱")]
        [Required(ErrorMessage = "請輸入產品名稱"), MaxLength(50, ErrorMessage = "名稱的長度不能超過50個字")]
        public string ProductName { get; set; }

        [Display(Name = "產品類別")]
        [Required(ErrorMessage = "請選擇產品類別")]
        public ProductClassEnum? ProductClass { get; set; }

        [Display(Name = "產品數量")]
        [Required(ErrorMessage = "請輸入產品數量")]
        public int? ProductCount { get; set; }

        [Display(Name = "圖片")]
        public IFormFile Photo { get; set; }
    }
}
