using Vote.Base;

namespace Vote.Entities
{
    public class Voter : Entity
    {
        public string FullName { get; set; }

        public Guid CandidateId { get; set; }
    }
}
