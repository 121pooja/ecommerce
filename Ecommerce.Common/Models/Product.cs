using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int DiscountId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
