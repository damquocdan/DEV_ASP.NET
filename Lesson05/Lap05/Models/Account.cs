using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace Lap05.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        
        [
            Display(Name ="Họ và tên"),
            Required(ErrorMessage ="Họ không được để trống"),
            MinLength(6,ErrorMessage ="Họ tên ít nhất là 6 ký tự"),
            MaxLength(20,ErrorMessage ="Họ tên tối đa 20 ký tự")
            
        ]
        public string FullName { get; set; }

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống")]
        ////[DataType(DataType.EmailAddress,ErrorMessage ="sai...")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Địa chỉ email không đúng định dạng")]
        [EmailAddress(ErrorMessage ="abb")]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        [DataType(DataType.PhoneNumber)]
        [Remote(action:"VerifyPhone",controller:"Account")]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-.]?([0-9]{3})[-.]?([0-9]{4})$", ErrorMessage = "Số điện thoại không đúng định dạng")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string Phone { get; set; }

        [Display(Name = "Địa chỉ thường trú")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "Địa chỉ không vượt quá 35 ký tự")]
        public string Address { get; set; }

        [Display(Name = "Ảnh đại điện")]
        public string Avatar { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "GIới tính")]
        public string Gender { get; set; }

        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Link facebook cá nhân")]
        [Required(ErrorMessage = "Link Facebook không được để trống")]
        [Url(ErrorMessage = "Url phải đúng định dạng bao gốm http hoặc https, tên miền VD: https://facebook.com/itvnsoft")]
        public string Facebook { get; set; }
    }
}
