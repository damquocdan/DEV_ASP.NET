using System.ComponentModel.DataAnnotations;

namespace Lap05.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Tên")]
        [Required(ErrorMessage ="Tên không được để trống")]
        [MinLength(6,ErrorMessage ="Ít nhất là 6 ký tự")]
        [MaxLength(150,ErrorMessage ="Ít nhất là 150 ký tự")]
        public string Name { get; set; }
    }
}
