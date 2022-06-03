using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Models
{
    public class OrderPayment
    {
        [Key]
        public int PaymentId { get; set; }
        public int Amount { get; set; }
        public string PaymentType { get; set; }
        public string Provider{ get; set; }
        public string Status{ get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
