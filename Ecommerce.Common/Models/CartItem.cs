using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Models
{
    public class CartItem
    {
        [Key]
        public int ItemId { get; set; }
        public int ProductId { get; set; }
        public string Quantity  { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
