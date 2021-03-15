using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace MakeProduct.Models.Product
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

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
        public string PhotoPath { get; set; }
    }
}
