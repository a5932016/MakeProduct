using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MakeProduct.ViewModels.Product
{
    public class ProductEditViewModel : ProductCreateViewModel
    {
        [Key]
        public int Id { get; set; }

        public string ExistingPhotoPath { get; set; }
    }
}
