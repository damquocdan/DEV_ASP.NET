using System.ComponentModel.DataAnnotations;

namespace Lesson09.Lap.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email không được để trống")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; }
    }
}
