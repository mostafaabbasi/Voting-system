using Microsoft.AspNetCore.Mvc;
using Vote.Entities;
using Vote.Services.Voter;

namespace Vote.Controllers
{
    [Route("api/voters")]
    [ApiController]
    public class VoterController : ControllerBase
    {
        private readonly IVoterService voterService;
        public VoterController()
        {
            voterService = new VoterService();
        }

        [HttpPost]
        public Voter Create(Voter model)
        {
            return voterService.Create(model);
        }

        [HttpGet("all")]
        public List<Voter> GetAll()
        {
            return voterService.GetAll();
        }

        [HttpDelete]
        public bool Delete(Guid id)
        {
            return voterService.Delete(id);
        }
    }
}
