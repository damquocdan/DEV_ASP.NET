using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
namespace Lesson03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId  { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        // danh sách các cuốn sách { nhớ using System.Collections.Generic)
        public List<Book> GetBookList() 
        { 
            List<Book> books = new List<Book>
            {
                new Book() {
                    Id = 1,
                    Title = "Chí phèo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image ="/images/products/1.jpg",
                    Price = 1,
                    TotalPage = 1,
                    Sumary=""
                },
                new Book() {
                    Id = 2,
                    Title = "Chí phèo",
                    AuthorId = 2,
                    GenreId = 2,
                    Image ="/images/products/2.jpg",
                    Price = 2,
                    TotalPage = 2,
                    Sumary=""
                },
                new Book() {
                    Id = 3,
                    Title = "Chí phèo",
                    AuthorId = 3,
                    GenreId = 3,
                    Image ="/images/products/3.jpg",
                    Price = 3,
                    TotalPage = 3,
                    Sumary=""
                },
                new Book() {
                    Id = 4,
                    Title = "Chí phèo",
                    AuthorId = 4,
                    GenreId = 4,
                    Image ="/images/products/4.jpg",
                    Price = 4,
                    TotalPage = 4,
                    Sumary=""
                },
                new Book() {
                    Id = 5,
                    Title = "Chí phèo",
                    AuthorId = 5,
                    GenreId = 5,
                    Image ="/images/products/5.jpg",
                    Price = 5,
                    TotalPage = 5,
                    Sumary=""
                },new Book() {
                    Id = 6,
                    Title = "Chí phèo",
                    AuthorId = 6,
                    GenreId = 6,
                    Image ="/images/products/6.jpg",
                    Price = 6,
                    TotalPage = 6,
                    Sumary=""
                }

            };
            return books;
        }
        // chi tiết một cuốn sách theo id( nhớ using System.linq)
        public Book GetBookById(int id)
        {
            Book book= this.GetBookList().FirstOrDefault(b=>b.Id==id);
            return book;
        }
        // selecListItem Author (using Microsoft.AspNetCore.Mvc.Rendering)
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="Nam Cao"},
            new SelectListItem{Value="2", Text="Ngô Tất Tố"},
            new SelectListItem{Value="3", Text="Adamkhoom"},
            new SelectListItem{Value="4", Text="Thiền sư thích Nhất hạnh"}
        };
        // SelectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="Nam Cao"},
            new SelectListItem{Value="2", Text="Ngô Tất Tố"},
            new SelectListItem{Value="3", Text="Adamkhoom"},
            new SelectListItem{Value="4", Text="Thiền sư thích Nhất hạnh"}
        };
    }
}
