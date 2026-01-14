using Microsoft.EntityFrameworkCore;

namespace TMS.Server.Models
{
    public class TaskDBContext:DbContext
    {
        public TaskDBContext(DbContextOptions<TaskDBContext> options):base(options)
        {
            
        }

        public DbSet<TaskInfo> TaskInfos { get; set; }
    }
}
