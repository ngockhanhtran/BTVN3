using BTVN3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BTVN3.Controllers
{
    public class ProductController : Controller
    {
        private List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { categoryID = 1, categoryName = "Quần Áo" },
                new Category { categoryID = 2, categoryName = "Túi xách" },
                new Category { categoryID = 3, categoryName = "Đồng hồ" },
                new Category { categoryID = 4, categoryName = "Tivi" },
                new Category { categoryID = 5, categoryName = "Tủ lạnh" },
                new Category { categoryID = 6, categoryName = "Máy bơm" },
                new Category { categoryID = 7, categoryName = "Quạt điện" },
                new Category { categoryID = 8, categoryName = "Lò sưởi" }
            };
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { productID = 1, categoryID = 1, productName = "Bộ đồ bơi cho trẻ em nam", oldPrice = 50000, price = 35000, image = "sp1.jpg", description = "Lorem ipsum dolor sit amet...", createdDate = "15/07/2021 12:00:00 SA", quantity = 10 },
                new Product { productID = 2, categoryID = 1, productName = "Bộ đồ bơi cho trẻ em nữ", oldPrice = 50000, price = 35000, image = "sp2.jpg", description = "Lorem ipsum dolor sit amet...", createdDate = "15/07/2021 12:00:00 SA", quantity = 5 },
                new Product { productID = 3, categoryID = 1, productName = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi", oldPrice = 50000, price = 35000, image = "sp3.jpg", description = "Lorem ipsum...", createdDate = "15/07/2021 12:00:00 SA", quantity = 0 },
                new Product { productID = 4, categoryID = 1, productName = "Bộ đồ bơi cho trẻ em thời trang", oldPrice = 50000, price = 35000, image = "sp4.jpg", description = "Lorem ipsum...", createdDate = "15/07/2021 12:00:00 SA", quantity = 8 },
                new Product { productID = 5, categoryID = 2, productName = "Túi thời trang mẫu mới 2021", oldPrice = 50000, price = 35000, image = "sp5.jpg", description = "Lorem ipsum...", createdDate = "15/07/2021 12:00:00 SA", quantity = 12 },
                new Product { productID = 6, categoryID = 2, productName = "Túi thời trang da cá sấu", oldPrice = 50000, price = 35000, image = "sp6.jpg", description = "Lorem ipsum...", createdDate = "15/07/2021 12:00:00 SA", quantity = 15 }
            };
        }

        public IActionResult GetAllProduct(int? categoryId)
        {
            ViewBag.Categories = GetCategories();

            var products = GetProducts();
            if (categoryId.HasValue)
            {
                products = products.Where(p => p.categoryID == categoryId.Value).ToList();
            }

            ViewData["productList"] = products;
            return View("getAllProduct");
        }

        public IActionResult Detail(int id)
        {
            var product = GetProducts().FirstOrDefault(p => p.productID == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}