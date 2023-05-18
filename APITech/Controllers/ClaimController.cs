using APITech;
using Microsoft.AspNetCore.Mvc;
using ARiad.APITech.Application.Models;
using System.Security.Claims;

namespace ARiad.APITech.WebAPI.Controllers
{
    [ApiController]
    public class ClaimController : Controller
    {

        [HttpGet("claim/{claimId}")]
        public Claim Get(int claimId)
        {
            return null;
        }

        [HttpGet("claims/{companyId}")]
        public List<Claim> GetClaims(int companyId)
        {
            return null;
        }
    }
}
