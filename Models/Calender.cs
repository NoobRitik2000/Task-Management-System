using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task_Management_System.Models
{
    public class Calender
    {
        [Key]
        public int EventID { get; set; }  // Primary key for the event

       // [ForeignKey("Task")]
       // public int TaskID { get; set; }  // Foreign key linking to the Task table

        [Required]
        public DateTime StartDate { get; set; }  // Start date and time of the event

        [Required]
        public DateTime EndDate { get; set; }  // End date and time of the event

        // Navigation property
        //public virtual Task Task { get; set; }  // The task associated with the event
    }
}
