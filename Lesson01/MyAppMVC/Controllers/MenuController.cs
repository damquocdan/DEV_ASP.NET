using Microsoft.AspNetCore.Mvc;

namespace MyAppMVC.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
