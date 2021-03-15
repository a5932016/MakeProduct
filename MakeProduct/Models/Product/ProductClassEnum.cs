using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MakeProduct.Models.Product
{
    /// <summary>
    /// 產品的枚舉
    /// </summary>
    public enum ProductClassEnum
    {
        [Display(Name = "未分類")]
        None,
        [Display(Name = "通訊")]
        Mobile,
        [Display(Name = "時尚")]
        Vogue,
        [Display(Name = "美妝")]
        Beauty
    }
}
