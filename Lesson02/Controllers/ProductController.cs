using Lesson02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Lesson02.Controllers
{

    public class ProductController : Controller
    {
     private List<Category> lstCategory = new List<Category>()
            {
                new Category { Id = 1,
                    Name = "Quần áo",
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
      private List<Product> lstProduct = new List<Product> {
                new Product {
                    Id = 1,
                    Name = "Quần áo nam",
                    Image="/Avatar/1.jpg",
                    Price=1000000,
                    SalePrice=699999,
                    CategoryID=1,
                    Description="Bộ đồ quần áo cho nam giới",
                    Status=true,
                    
                },
                new Product {
                    Id = 2,
                    Name = "Quần áo nữ",
                    Image="/Avatar/2.jpg",
                    Price=3000000,
                    SalePrice=2490000,
                    CategoryID=1,
                    Description="Test",
                    Status=true,
                    
                },
                new Product {
                    Id = 3,
                    Name = "Quần áo cho trẻ nhỏ",
                    Image="/Avatar/3.jpg",
                    Price=100900,
                    SalePrice=19900,
                    CategoryID=1,
                    Description="Test",
                    Status=true,
                    
                },
                new Product {
                    Id = 4,
                    Name = "Đồ gia dụng",
                    Image="/Avatar/4.jpg",
                    Price=100,
                    SalePrice=100,
                    CategoryID=4,
                    Description="Test",
                    Status=true,

                },
                new Product {
                    Id = 5,
                    Name = "Thực phẩm an toàn gia đình",
                    Image="/Avatar/5.jpg",
                    Price=100,
                    SalePrice=100,
                    CategoryID=5,
                    Description="Test",
                    Status=true,
                
                },
                new Product {
                    Id = 6,
                    Name = "Dụng cụ vườn nhà",
                    Image="/Avatar/6.jpg",
                    Price=100,
                    SalePrice=100,
                    CategoryID=6,
                    Description="Test",
                    Status=true,

                }
            };
        public IActionResult Index(int ?id)
        {
           
            ViewBag.Categories = lstCategory;
            if (id != null)
            {
                lstProduct = lstProduct.Where(x=>x.CategoryID == id.Value).ToList();   
            }
            ViewBag.Products = lstProduct;
            return View();
            

        }
        public IActionResult Productct(int id)
        {
            List<Product> product = new List<Product>
            {
                new Product {
                    Id = 1,
                    Name = "Quần áo nam",
                    Image="/Avatar/1.jpg",
                    Price=1000000,
                    SalePrice=699999,
                    CategoryID=1,
                    Description="Bộ đồ quần áo cho nam giới",
                    Status=true,

                },
                new Product {
                    Id = 2,
                    Name = "Quần áo nữ",
                    Image="/Avatar/2.jpg",
                    Price=3000000,
                    SalePrice=2490000,
                    CategoryID=1,
                    Description="Test",
                    Status=true,

                },
                new Product {
                    Id = 3,
                    Name = "Quần áo cho trẻ nhỏ",
                    Image="/Avatar/3.jpg",
                    Price=100900,
                    SalePrice=19900,
                    CategoryID=1,
                    Description="Test",
                    Status=true,

                },
                new Product {
                    Id = 4,
                    Name = "Đồ gia dụng",
                    Image="/Avatar/4.jpg",
                    Price=100,
                    SalePrice=100,
                    CategoryID=4,
                    Description="Test",
                    Status=true,

                },
                new Product {
                    Id = 5,
                    Name = "Thực phẩm an toàn gia đình",
                    Image="/Avatar/5.jpg",
                    Price=100,
                    SalePrice=100,
                    CategoryID=5,
                    Description="Test",
                    Status=true,

                },
                new Product {
                    Id = 6,
                    Name = "Dụng cụ vườn nhà",
                    Image="/Avatar/6.jpg",
                    Price=100,
                    SalePrice=100,
                    CategoryID=6,
                    Description="Test",
                    Status=true,

                }

            };
            Product product1 = product.FirstOrDefault(pd => pd.Id == id);
            ViewBag.product = product1;
            return View();
        }
       
    }
}
