using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MakeProduct.Models.Product;

namespace MakeProduct.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product.Product>().HasData(
                new Product.Product { Id = 1, ProductName = "帽子", ProductClass = ProductClassEnum.Beauty, ProductCount = 1 },
                new Product.Product { Id = 2, ProductName = "衣服", ProductClass = ProductClassEnum.Mobile, ProductCount = 2 },
                new Product.Product { Id = 3, ProductName = "褲子", ProductClass = ProductClassEnum.Vogue, ProductCount = 3 },
                new Product.Product { Id = 4, ProductName = "鞋子", ProductClass = ProductClassEnum.Beauty, ProductCount = 4 });
        }
    }
}
