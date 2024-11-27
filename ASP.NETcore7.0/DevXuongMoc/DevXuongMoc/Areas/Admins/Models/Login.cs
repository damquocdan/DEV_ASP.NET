using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Areas.Admins.Models
{
    public class Login
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}
