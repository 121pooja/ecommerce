

using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Models
{
    public class AdminUser
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserType { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
