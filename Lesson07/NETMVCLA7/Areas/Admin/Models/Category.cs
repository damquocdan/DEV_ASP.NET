using System.ComponentModel.DataAnnotations;

namespace NETMVCLA7.Areas.Admin.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Họ và tên")]
        public string Name { get; set; }
    }
}
