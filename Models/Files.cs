using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task_Management_System.Models
{
    public class Files
    {
        [Key]
        public int FileID { get; set; }  // Primary key for the file

       // [ForeignKey("Task")]
        //public int TaskID { get; set; }  // Foreign key linking to the Task table

        [ForeignKey("User")]
        public string UploadedBy { get; set; }  // Foreign key linking to the User table (who uploaded the file)

        public DateTime UploadDate { get; set; }  // Date and time when the file was uploaded

        // Navigation properties
        //public virtual Task Task { get; set; }  // The task associated with the file
        public virtual User User { get; set; }  // The user who uploaded the file
    }
}
