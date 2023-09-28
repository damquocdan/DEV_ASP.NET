using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Lesson08.Lab.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        [Display(Name = "Họ và tên người nhận")] public string Name { get; set; }
        [Display(Name = "Địa chỉ email người nhận")] public string Email { get; set; }
        [Display(Name = "Địa chỉ người nhận")]
        public string Address { get; set; }
        [Display(Name = "Ngày đặt")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Trạng thái")]
        public byte Status { get; set; }
        // Khóa ngoại tới bảng Customer 
        public Customer Customer { get; set; }
    }
}
