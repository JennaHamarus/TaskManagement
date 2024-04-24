using backend.Core.Enums;

namespace backend.Core.Entities
{
    public class Job: BaseEntity
    {
        public string Title { get; set; }
        public JobLevel Level { get; set; }

        //Relations
        public long ActivityId { get; set; }
        public Activity Activity { get; set;}

        public ICollection<Candidate> Candidates { get; set; }
    }
}
