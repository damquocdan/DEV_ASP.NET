using System.ComponentModel.DataAnnotations;

namespace Lap05.Models
{
    public class Product :Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Tên")]
        [Required(ErrorMessage ="Vui lòng không để  trống")]
        [MinLength(6,ErrorMessage ="ít nhât là 6 ký tự")]
        [MaxLength(150,ErrorMessage ="Nhiều nhất 150 ký tự")]
        public string Name { get; set; }
        [Display(Name="Ảnh")]
        [Required(ErrorMessage ="Vui lòng không để trống ô nhập ảnh")]
        public string Image { get; set; }

        [Display(Name ="Giá gốc")]
        [Required(ErrorMessage ="Vui lòng không để trống giá gốc")]
        [Range(100000,99999999,ErrorMessage ="giá phải lớn hơn 100000")]
        [DataType(DataType.Text)]
        public float Price { get; set; }

        [Display(Name="Giảm giá")]
        [Required(ErrorMessage ="vui lòng không để trống giá sale")]//compare validation ASP.Net MVc
        public float SalePrice { get; set; }


        [Display(Name="Danh mục Id")]
        public int CategoryId { get; set; }

        [Display(Name="Mô tả")]
        [MaxLength(1500,ErrorMessage ="Không vượt quá 1500 ký tự")]
        //#regularExpression 
        public string Description { get; set; }
    }
}
