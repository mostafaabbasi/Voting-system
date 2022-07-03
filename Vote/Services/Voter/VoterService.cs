using Vote.Repository;

namespace Vote.Services.Voter
{
    public class VoterService : GenericRepository<Entities.Voter>, IVoterService
    {
        private readonly IGenericRepository<Entities.Candidate> _candidateRepository;
        private Entities.Voter _voter;

        public VoterService()
        {
            _candidateRepository = new GenericRepository<Entities.Candidate>();
        }

        public override Entities.Voter Create(Entities.Voter entity)
        {
            entity.Id = Guid.NewGuid();
            _voter = entity;
            var result = base.Create(entity);
            AddVoterCount(result.CandidateId);
            return result;
        }

        public override List<Entities.Voter> GetAll()
        {
            return base.GetAll();
        }

        public override bool Delete(Guid id)
        {
            return base.Delete(id);
        }

        #region Private Method
        private void AddVoterCount(Guid candidateId)
        {
            var candidate = _candidateRepository.GetById(candidateId);

            if (candidate is not null)
            {
                candidate.Votes.Add(_voter);
            }

        }
        #endregion

    }
}
