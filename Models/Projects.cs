using System.ComponentModel.DataAnnotations;

namespace Task_Management_System.Models
{
    public class Projects
    {
        [Key]
        public int ProjectID { get; set; }
        [Required]
        public string projectName { get; set; }
        
        public string projectDescription { get; set; }
        [Required]
        public DateTime startDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }

        public string Priority { get; set; }
        [Required]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
