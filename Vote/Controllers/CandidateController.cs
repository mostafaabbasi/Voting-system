using Microsoft.AspNetCore.Mvc;
using Vote.Entities;
using Vote.Services.Candidate;

namespace Vote.Controllers
{
    [Route("api/candidates")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService candidateService;
        public CandidateController()
        {
            candidateService = new CandidateSerivce();
        }

        [HttpPost]
        public Candidate Create(Candidate model)
        {
            return candidateService.Create(model);
        }

        [HttpGet("all")]
        public List<Candidate> GetAll()
        {
            return candidateService.GetAll();
        }

        [HttpDelete]
        public bool Delete(Guid id)
        {
            return candidateService.Delete(id);
        }
    }
}
