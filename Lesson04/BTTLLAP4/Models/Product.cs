using System.ComponentModel.DataAnnotations;

namespace BTTLLAP4.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Họ và tên")]
        public string Name { get; set; }
        [Display(Name = "Giá gốc")]
        public double Price { get; set; }
        [Display(Name = "Giảm giá còn")]
        public double SalePrice { get; set; }
        [Display(Name = "Ngày đăng")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Ảnh sản phẩm")]
        public string Image { get; set; }
        [Display(Name = "Sản phẩm chi tiết")]
        public int CategoryId { get; set; }
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
    }
}
