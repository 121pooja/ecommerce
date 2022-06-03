using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Models
{
   public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId{ get; set; }
        public  int PaymentId { get; set; }
        public int Delivered { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


    }
}
