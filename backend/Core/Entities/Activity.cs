using backend.Core.Enums;

namespace backend.Core.Entities
{
    public class Activity : BaseEntity
    {
        public string Name { get; set; }
        public ActivityStatus Status  { get; set; }

        //Relations
        public ICollection<Job> Jobs { get;}
    }
}
