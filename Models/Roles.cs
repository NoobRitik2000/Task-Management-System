using System.ComponentModel.DataAnnotations;

namespace Task_Management_System.Models
{
    public class Roles
    {
        [Key]
        public string RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
