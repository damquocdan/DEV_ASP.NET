using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreLAB6_EF.Models
{
    public class Book
    {
        [Key]
        [Column(TypeName ="nvarchar(10)")]
        public string BookId { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        [Required(ErrorMessage ="Tên tiêu đề không được để trống")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Tên tác giả không được để trống")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Tên release không được để trống")]
        public int Release { get; set; }

        [Required(ErrorMessage = "Tên giá không được để trống")]
        public float Price { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Ảnh không được để trống")]
        public string Picture { get; set; }
        [Key]
        public int CategoryID { get; set; }
        public ICollection<Category> categories { get ; set; }


    }
}
