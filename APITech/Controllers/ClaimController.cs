using APITech;
using Microsoft.AspNetCore.Mvc;
using ARiad.APITech.Application.Models;

namespace ARiad.APITech.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClaimController : Controller
    {

        [HttpGet(Name = "GetClaim")]
        public ClaimResponse Get()
        {
            return new Application.Models.CompanyResponse();
        }
    }
}
