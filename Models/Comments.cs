
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task_Management_System.Models
{
    public class Comments
    {
        [Key]
        public int CommentID { get; set; }  // Primary key

        //[ForeignKey("Task")]
        //public int TaskID { get; set; }  // Foreign key to Task table

        [Required]
        [MaxLength(1000)]  // Set a maximum length for the comment text
        public string CommentText { get; set; }  // The actual comment

        [ForeignKey("User")]
        public string CommentedBy { get; set; }  // Foreign key to User (who commented)

        public DateTime CommentDate { get; set; }  // Date and time of the comment

        // Navigation properties
        //public virtual Task Task { get; set; }  // The task to which the comment is associated
        public virtual User User { get; set; }  // The user who made the comment
    }
}
