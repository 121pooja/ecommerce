using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Models
{
    public class ProductBrand
    {
        [Key]
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
