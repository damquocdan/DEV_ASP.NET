namespace NETMVCLA7.Areas.Admin.Models
{
    public class Data
    {
        public static List<Category> categories = new List<Category>()
        {

            new Category() {
                Id = 1,
                Name = "Quần áo nam"
            }
        };
        public static List<Category> GetCategories()
        {
            return categories;
        }
        public static Category? GetProductById(int Id)
        {
            var category = categories.FirstOrDefault(p => p.Id == Id);
            return category;
        }
    }
}
