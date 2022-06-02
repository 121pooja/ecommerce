
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Models
{
  public class UserAddress
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Address { get; set; }
        public string  Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
