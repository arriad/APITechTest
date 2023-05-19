using ARiad.APITech.Application.Models.Response;
using Microsoft.AspNetCore.Mvc;
using ARiad.APITech.Application.Models.Response;
using ARiad.APITech.Application.Services;

namespace ARiad.APITech.WebAPI.Controllers
{
    [ApiController]
    public class CompanyController : Controller
    {
        private readonly DataManagerService _dataManagerService;
        public CompanyController(DataManagerService dataManagerService)
        {
            _dataManagerService = dataManagerService;
        }

        [HttpGet("company/{companyId}")]
        public async Task<Company> Get(int companyId)
        {
            return await _dataManagerService.GetCompany(companyId);
        }

    }
}
