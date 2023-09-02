using Lesson02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02.Controllers
{
    public class ProductController : Controller
    {
        
        public IActionResult Index()
        {
            List<Product> products = new List<Product> {
                new Product {
                    Id = 1,
                    Name = "Test",
                    Image=Url.Content("~/Avatar/1.jpg"),
                    Price=100,
                    SalePrice=100,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                },
                new Product {
                    Id = 2,
                    Name = "Test",
                    Image=Url.Content("~/Avatar/2.jpg"),
                    Price=100,
                    SalePrice=100,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                },
                new Product {
                    Id = 3,
                    Name = "Test",
                    Image=Url.Content("~/Avatar/3.jpg"),
                    Price=100,
                    SalePrice=100,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                },
                new Product {
                    Id = 4,
                    Name = "Test",
                    Image=Url.Content("~/Avatar/4.jpg"),
                    Price=100,
                    SalePrice=100,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                },
                new Product {
                    Id = 5,
                    Name = "Test",
                    Image=Url.Content("~/Avatar/5.jpg"),
                    Price=100,
                    SalePrice=100,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                },
                new Product {
                    Id = 6,
                    Name = "Test",
                    Image=Url.Content("~/Avatar/6.jpg"),
                    Price=100,
                    SalePrice=100,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                }
            };
            ViewBag.Products = products;
            return View();
            

        }
        [Route("sanpham", Name = "category")]
        public IActionResult Category(int id) {
            List<Category> categories = new List<Category>
            {
                new Category { Id = 1,
                    Name = "Test",
                },
                new Category { Id = 2,
                    Name = "Test",
                },
                new Category { Id = 3,
                    Name = "Test",
                },
                new Category { Id = 4,
                    Name = "Test",
                },
                new Category { Id = 5,
                    Name = "Test",
                },
                new Category { Id = 6,
                    Name = "Test",
                }

            };
            Account product = categories.FirstOrDefault(c => c.Id == id);
            ViewBag.roduct = product;
            return View();
        }
   
       
    }
}
