using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeProduct.ViewModels.Product
{
    public class ProductDetailViewModel
    {
        public MakeProduct.Models.Product.Product product { get; set; }

        public string PageTitle { get; set; }
    }
}
