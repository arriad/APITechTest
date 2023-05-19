using ARiad.APITech.Application.Models.Response;
using ARiad.APITech.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARiad.APITech.WebAPI.Controllers
{
    [ApiController]
    public class ClaimController : Controller
    {
        private readonly DataManagerService _dataManagerService;
        public ClaimController(DataManagerService dataManagerService)
        {
            _dataManagerService = dataManagerService;
        }

        [HttpGet("claim/{claimId}")]
        public Claim Get(string claimId)
        {
            return _dataManagerService.getcl
        }

        [HttpGet("claims/{companyId}")]
        public List<Claim> GetClaims(int companyId)
        {
            return null;
        }
    }
}
