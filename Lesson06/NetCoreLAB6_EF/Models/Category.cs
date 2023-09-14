using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreLAB6_EF.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Tên danh mục không được để trống")]
        [Column(TypeName ="nvarchar(100)")]
        public string CategoryName { get; set; }

        public ICollection<Book> books { get; set;}
    }
}
