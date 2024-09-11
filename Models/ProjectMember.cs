using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management_System.Models
{
    public class ProjectMember
    {
        [Key]  // Specifies this is the primary key
        public int ProjectMemberID { get; set; }

        [ForeignKey("Project")]
        public int ProjectID { get; set; }  // Foreign key to Project table

        [ForeignKey("User")]
        public string UserID { get; set; }  // Foreign key to User table

     
    }
}
