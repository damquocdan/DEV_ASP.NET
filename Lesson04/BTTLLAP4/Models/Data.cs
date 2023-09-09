using System.Linq;
namespace BTTLLAP4.Models
{
    public class Data
    {
        public static List<Product> products = new List<Product>()
        {
            
            new Product() {
                Id = 1,
                Name = "Quần áo nam",
                Price = 2000,
                SalePrice = 1000,
                CreatedDate = DateTime.Now,
                Image = "Image/1.jpg",
                CategoryId = 1,
                Description = "aâ"

            },
            new Product()
            {
                Id = 1,
                Name = "Quần áo nam",
                Price = 2000,
                SalePrice = 1000,
                CreatedDate = DateTime.Now,
                Image = "Image/2.jpg",
                CategoryId = 1,
                Description = "aâ"

            },
            new Product()
            {
                Id = 1,
                Name = "Quần áo nam",
                Price = 2000,
                SalePrice = 1000,
                CreatedDate = DateTime.Now,
                Image = "Image/3.jpg",
                CategoryId = 1,
                Description = "aâ"

            },
            new Product()
            {
                Id = 1,
                Name = "Quần áo nam",
                Price = 2000,
                SalePrice = 1000,
                CreatedDate = DateTime.Now,
                Image = "Image/4.jpg",
                CategoryId = 1,
                Description = "aâ"

            }
            };
        public static List<Product> GetProducts()
        {
            return products;
        }
        public static Product? GetProductById(int Id)
        {
            var product = products.FirstOrDefault(p => p.Id == Id);
            return product;
        }
    }
        
}

