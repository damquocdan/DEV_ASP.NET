using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Lesson08.Lab.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public byte Status { get; set; }
        public int ViewCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Image { get; set; }
        [Required]
        [StringLength(1500)]
        [DataType(DataType.Text)]
        public string Description { get; set; }
    }
}
