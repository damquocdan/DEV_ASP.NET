
using Lesson09.Lap.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson09.Lap.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class LoginController : Controller
    {
        public DevXuongMocContext _context;

        public LoginController(DevXuongMocContext context)
        {
            _context = context;
        }

        [HttpGet]// get, hiển thị form để nhập dữ liệu
        public IActionResult Index()
        { 
            return View();
        }
        [HttpPost] // POST -> khi submit form
        public IActionResult Index(Login model) {
            if (!ModelState.IsValid)
            {
                return View(model);// trả về trạng thái lỗi
            }
            // sẽ xử lý logic phần đăng nhập tại đây
            var pass = model.Password;
            var dataLogin = _context.AdminUsers.Where(x => x.Email.Equals(model.Email)&& x.Password.Equals(pass)).FirstOrDefault();
            if (dataLogin != null)
            {
                // Lưu session khi đăng nhập thành công
                HttpContext.Session.SetString("AdminLogin", model.Email);


                return RedirectToAction("Index", "Dashboard");
            }
            return View(model);
            
        }
        [HttpGet]// thoát đăng nhập, huỷ session
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminLogin"); // huỷ session với key AdminLogin đã lưu trước đó

            return RedirectToAction("Index");
        }
    }
}
