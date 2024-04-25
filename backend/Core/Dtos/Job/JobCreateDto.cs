using backend.Core.Enums;

namespace backend.Core.Dtos.Job
{
    public class JobCreateDto
    {
        public string Title { get; set; }
        public JobStatus Status { get; set; }
        public long ActivityId { get; set; }
    }
}
