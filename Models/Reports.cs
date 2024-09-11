using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task_Management_System.Models
{
    public class Reports
    {
        [Key]
        public int ReportID { get; set; }  // Primary key for the report

        [ForeignKey("Project")]
        public string ProjectID { get; set; }  // Foreign key linking to the Project table

        [ForeignKey("User")]
        public string GeneratedBy { get; set; }  // Foreign key linking to the User table (who generated the report)

        [Required]
        public DateTime GenerateDate { get; set; }  // Date and time when the report was generated

        [Required]
        [Column(TypeName = "json")]  // Specifies that ReportData will be stored in JSON format
        public string ReportData { get; set; }  // Report data stored as a JSON string

        // Navigation properties
       
        public virtual User User { get; set; }  // The user who generated the report
    }
}
