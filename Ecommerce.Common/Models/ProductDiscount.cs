using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Models
{
    public class ProductDiscount
    {
        [Key]
        public int DiscountId { get; set; }
        public string DiscountName { get; set; }
        public int DiscountPercentage { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
