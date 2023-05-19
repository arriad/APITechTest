using ARiad.APITech.Application.Models.Response;
using Data=ARiad.APITech.Application.Models.Database;
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
        public async Task<ClaimResponse> Get(string ucr)
        {
            return await _dataManagerService.GetClaim(ucr);
        }

        [HttpGet("claims/{companyId}")]
        public async Task<List<ClaimResponse>> GetClaims(int companyId)
        {
            return await _dataManagerService.GetClaims(companyId);
        }

        [HttpPut("claim/update")]
        public async Task<bool> UpdateClaim([FromBody] Data.Claim request)
        {
            return await _dataManagerService.UpdateClaim(request);
        }
    }
}
