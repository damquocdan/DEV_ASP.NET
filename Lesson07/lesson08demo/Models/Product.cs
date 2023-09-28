using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Lesson08.Lab.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [DataType(DataType.Upload)]
        public string Image { get; set; }
        [Required]
        public float Price { get; set; }
        public float SalePrice { get; set; }
        public byte Status { get; set; }
        [DataType(DataType.Text)]
        [StringLength(1000)]
        public string Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }  // khóa ngoại tới bảng Category 
        public Category Category { get; set; }
    }
}
