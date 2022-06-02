using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Models
{
    public class ProductCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
