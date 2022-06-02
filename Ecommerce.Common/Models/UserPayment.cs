

using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Models
{
    public class UserPayment
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PaymentType { get; set; }
        public string Provider { get; set; }
        public int AccountNo { get; set; }
        public string Expiry { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
