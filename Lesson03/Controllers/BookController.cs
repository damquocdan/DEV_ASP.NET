using Microsoft.AspNetCore.Mvc;
using Lesson03.Models;

namespace Lesson03.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index()
        {
            // danh sách genres convert SelectListItem để hiển thị trên combobox
            ViewBag.authors = book.Authors;
            ViewBag.genres= book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
        public IActionResult Create()
        {
            ViewBag.authors = book.Authors;// truyền dữ liệu SelectListItem qua view
            ViewBag.genres=book.Genres;// truyền dữ liệu SelectListItem qua View
            Book model = new Book();
            return View(model);
        }
        public IActionResult Edit(int id) {

            ViewBag.authors = book.Authors;// truyền dữ liệu SelectListItem qua view
            ViewBag.genres = book.Genres;// truyền dữ liệu SelectListItem qua View
            Book model = book.GetBookById(id);
            return View(model);
        }
    }
}
