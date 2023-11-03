using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevXuongMoc.Models;

[Table("ADMIN_USER")]
public partial class AdminUser
{
    [Key]
    public int Id { get; set; }

    [
        Required(ErrorMessage ="Không được để trống"),
        MinLength(6, ErrorMessage = "Họ tên ít nhất là 6 ký tự"),
        MaxLength(20, ErrorMessage = "Họ tên tối đa 20 ký tự")
    ]
    public string? Account { get; set; }

    [Required(ErrorMessage = "Không được để trống")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Không được để trống")]
    public int? MaNhanSu { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public string? Phone { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Địa chỉ email không đúng định dạng")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public string? Avatar { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public int? IdPhongBan { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public DateTime? NgayTao { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public string? NguoiTao { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public DateTime? NgayCapNhat { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public string? NguoiCapNhat { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public string? SessionToken { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public string? Salt { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public bool? IsAdmin { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public int? TrangThai { get; set; }
    [Required(ErrorMessage = "Không được để trống")]
    public bool? IsDelete { get; set; }
}
