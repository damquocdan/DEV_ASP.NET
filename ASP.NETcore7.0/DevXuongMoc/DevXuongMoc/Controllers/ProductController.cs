using DevXuongMoc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DevXuongMoc.Controllers
{
    public class ProductController : Controller
    {
        private readonly DevXuongMocSqlContext _context;
        public ProductController(DevXuongMocSqlContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Products.ToListAsync();

            return View(data);
        }
    }
}
