using APITech;
using Microsoft.AspNetCore.Mvc;
using ARiad.APITech.Application.Models.Response;

namespace ARiad.APITech.WebAPI.Controllers
{
    [ApiController]
    public class CompanyController : Controller
    {

        [HttpGet("company/{companyId}")]
        public Company Get(int companyId)
        {
            return new Company();
        }

    }
}
