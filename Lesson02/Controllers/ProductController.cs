using Lesson02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

namespace Lesson02.Controllers
{
    public class ProductController : Controller
    {
        
        public IActionResult Index()
        {
            List<Product> products = new List<Product> {
                new Product {
                    Id = 1,
                    Name = "Quần áo nam",
                    Image=Url.Content("~/Image/1.jpg"),
                    Price=1000000,
                    SalePrice=699999,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                },
                new Product {
                    Id = 2,
                    Name = "Quần áo nữ",
                    Image=Url.Content("~/Image/2.jpg"),
                    Price=3000000,
                    SalePrice=2490000,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                },
                new Product {
                    Id = 3,
                    Name = "Quần áo cho trẻ nhỏ",
                    Image=Url.Content("~/Image/3.jpg"),
                    Price=100900,
                    SalePrice=19900,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                },
                new Product {
                    Id = 4,
                    Name = "Đồ gia dụng",
                    Image=Url.Content("~/Image/4.jpg"),
                    Price=100,
                    SalePrice=100,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                },
                new Product {
                    Id = 5,
                    Name = "Thực phẩm an toàn gia đình",
                    Image=Url.Content("~/Image/5.jpg"),
                    Price=100,
                    SalePrice=100,
                    CategoryID="m1",
                    Description="Test",
                    Status="test",
                    CreateAt="dddd"
                },
                new Product {
                    Id = 6,
                    Name = "Dụng cụ vườn nhà",
                    Image=Url.Content("~/Image/6.jpg"),
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
                    Name = "Quần áo nam",
                },
                new Category { Id = 2,
                    Name = "Quần áo nữ",
                },
                new Category { Id = 3,
                    Name = "Quần áo cho trẻ nhỏ",
                },
                new Category { Id = 4,
                    Name = "Đồ gia dụng",
                },
                new Category { Id = 5,
                    Name = "Thực phẩm an toàn gia đình",
                },
                new Category { Id = 6,
                    Name = "Dụng cụ vườn nhà",
                }

            };
            Account product = categories.ToImmutableArray(c => c.Id == id);
            ViewBag.roduct = product;
            return View();
        }
   
       
    }
}
