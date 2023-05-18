using APITech;
using Microsoft.AspNetCore.Mvc;
using ARiad.APITech.Application.Models;

namespace ARiad.APITech.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : Controller
    {

        [HttpGet(Name = "GetCompany")]
        public CompanyResponse Get()
        {
            return new CompanyResponse();
        }

    }
}
