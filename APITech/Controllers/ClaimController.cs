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

        [HttpGet("claim/{ucr}")]
        public async Task<Claim> Get(string ucr)
        {
            return await _dataManagerService.GetClaim(ucr);
        }

        [HttpGet("claims/{companyId}")]
        public async Task<List<Claim>> GetClaims(int companyId)
        {
            return await _dataManagerService.GetClaims(companyId);
        }
    }
}
