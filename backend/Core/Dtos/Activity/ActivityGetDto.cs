using backend.Core.Enums;

namespace backend.Core.Dtos.Activity
{
    public class ActivityGetDto
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public ActivityStatus Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
