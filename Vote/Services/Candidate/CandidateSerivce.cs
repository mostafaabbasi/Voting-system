using Vote.Repository;

namespace Vote.Services.Candidate
{
    public class CandidateSerivce : GenericRepository<Entities.Candidate>, ICandidateService
    {
        public override Entities.Candidate Create(Entities.Candidate entity)
        {
            entity.Id = Guid.NewGuid();
            return base.Create(entity);
        }

        public override List<Entities.Candidate> GetAll()
        {
            return base.GetAll();
        }

        public override bool Delete(Guid id)
        {
            return base.Delete(id);
        }
    }
}
