using Vote.Base;

namespace Vote.Entities
{
    public class Candidate : Entity
    {
        public Candidate()
        {
            Votes = new List<Voter>();
        }
        public string FullName { get; set; }

        public int VoteCount => Votes.Count();

        public List<Voter> Votes { get; }
    }
}
