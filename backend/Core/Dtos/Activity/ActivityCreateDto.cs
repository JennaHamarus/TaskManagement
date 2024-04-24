using backend.Core.Enums;

namespace backend.Core.Dtos.Activity
{
    public class ActivityCreateDto
    {
        public string Name { get; set; }
        public ActivityStatus Status { get; set; }
    }
}
