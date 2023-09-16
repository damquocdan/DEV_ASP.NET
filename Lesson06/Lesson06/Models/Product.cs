using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson06.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public string Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]
        [Required(ErrorMessage ="Tên sản phẩm không được để trống")]
        [StringLength(150,ErrorMessage ="Tên sản phẩm giới hạn 150 ký tự")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Giá sản phầm không được để trống")]
        public float Price { get; set; }

        public float SalePrice { get; set; }
        public byte Status { get; set; }

        [StringLength(1000,ErrorMessage ="Nội dung mô tả giới hạn 1000 ký tự")]
        [Column(TypeName = "ntext")]
        public string Descriptions { get; set; }

        [Required(ErrorMessage ="Danh mục sản phẩm không được để trống")]
        public int CategoryID { get; set; }
        public DateTime CreatedDate { get; set; }
        // khoá ngoại tới bảng Category
        public Category Category { get; set; }
     


    }
}
