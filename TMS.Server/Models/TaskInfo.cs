using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMS.Server.Models
{
    public class TaskInfo
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string taskName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string assignee { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string description { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string status { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public DateTime createdAt { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public Boolean isComplete { get; set; }

    }
}
