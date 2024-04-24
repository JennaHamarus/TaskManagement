using backend.Core.Entities;
using backend.Core.Enums;

namespace backend.Core.Dtos.Job
{
    public class JobGetDto
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public JobLevel Level { get; set; }
        public long ActivityId { get; set; }
        public string ActivityName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
