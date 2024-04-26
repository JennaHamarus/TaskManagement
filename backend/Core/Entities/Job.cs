using backend.Core.Enums;

namespace backend.Core.Entities
{
    public class Job: BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public JobStatus Status { get; set; }

        //Relations
        public long ActivityId { get; set; }
        public Activity Activity { get; set;}
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
