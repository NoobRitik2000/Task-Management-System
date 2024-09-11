
using System.ComponentModel.DataAnnotations;

namespace Task_Management_System.Models
{
    public class User
    {
        [Key]
        public string UserId { get; set; } // Primary Key, better naming and non-nullable

        [Required]
        public string userName { get; set; } // Property name in PascalCase

        [Required]

        [EmailAddress]
        public string Email { get; set; } 


        [Required]
    
        public string Password { get; set; }

        [Required]
        public string RoleName { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
