using DevXuongMoc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevXuongMoc.Controllers
{
    public class NewController : Controller
    {
        private readonly DevXuongMocSqlContext _context;
        public NewController(DevXuongMocSqlContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.News.DefaultIfEmpty().ToListAsync();

            return View(data);
        }
    }
}
