using Microsoft.EntityFrameworkCore;

namespace Task_Management_System.Models
{
    public class AppDBContext : DbContext
    {
        // Constructor
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Files> Files { get; set; }
        public DbSet<Reports> Reports { get; set; }
        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<Calender> Calenders { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
    }
}
