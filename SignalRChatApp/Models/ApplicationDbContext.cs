using Microsoft.EntityFrameworkCore;

namespace SignalRChatApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 

        }
        public DbSet<ChatMessage> ChatMessages { get; set; }
    }
}
