using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task_Management_System.Models
{
    public class Notifications
    {
        [Key]
        public int NotificationID { get; set; }  // Primary key for the notification

        [ForeignKey("User")]
        public string UserID { get; set; }  // Foreign key to the User table (who received the notification)

        [Required]
        [MaxLength(500)]  // Limit the message to 500 characters (adjustable)
        public string Message { get; set; }  // Notification message

        public bool ReadStatus { get; set; }  // Status to check if the notification has been read (true/false)

        public DateTime NotificationDate { get; set; }  // Date and time of the notification

        // Navigation property
        public virtual User User { get; set; }  // The user who received the notification
    }
}
