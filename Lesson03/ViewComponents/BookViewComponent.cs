using Microsoft.AspNetCore.Mvc;
using Lesson03.Models;
namespace Lesson03.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();
            return View(book);
        }
    }
}