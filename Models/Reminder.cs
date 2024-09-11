using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task_Management_System.Models
{
    public class Reminder
    {
        [Key]
        public int ReminderID { get; set; }  // Primary key for the reminder

        //[ForeignKey("Task")]
        //public int TaskID { get; set; }  // Foreign key linking to the Task table

        [Required]
        public DateTime ReminderTime { get; set; }  // Date and time when the reminder is set

        public bool IsSent { get; set; }  // Status to check if the reminder has been sent (true/false)

        public DateTime? SentDate { get; set; }  // Optional date and time when the reminder was sent

        // Navigation property
        //public virtual Task Task { get; set; }  // The task associated with the reminder
    }
}
