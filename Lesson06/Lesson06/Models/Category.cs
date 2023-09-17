using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
namespace Lesson06.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Tên danh mục không được để trống")]
        [StringLength(100)]
        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName ="tinyint")]
        public byte Status { get; set; }
        // Danh sách sản phẩm theo danh muc 

        public DateTime CreatedDate { get; set; }
        public ICollection<Product> Products { get; set;}
    }
}
