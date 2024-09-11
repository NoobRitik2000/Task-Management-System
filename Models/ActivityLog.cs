using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task_Management_System.Models
{
    public class ActivityLog
    {
        [Key]
        public int ActivityID { get; set; }  // Primary key for the activity log

        [ForeignKey("Project")]
        public int ProjectID { get; set; }  // Foreign key linking to the Project table

       // [ForeignKey("Task")]
       // public int TaskID { get; set; }  // Foreign key linking to the Task table

        [Required]
        [MaxLength(1000)]  // Limit the description to 1000 characters (adjustable)
        public string ActivityDescription { get; set; }  // Description of the activity

        [ForeignKey("User")]
        public string PerformedBy { get; set; }  // Foreign key linking to the User table (who performed the activity)

        public DateTime PerformedDate { get; set; }  // Date and time when the activity was performed

        // Navigation properties
      
        //public virtual Task Task { get; set; }  // The task associated with the activity
        public virtual User User { get; set; }  // The user who performed the activity
    }
}
