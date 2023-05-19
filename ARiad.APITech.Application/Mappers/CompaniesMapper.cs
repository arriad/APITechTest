using Database=ARiad.APITech.Application.Models.Database;
using Response=ARiad.APITech.Application.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARiad.APITech.Application.Mappers
{
    public static class CompaniesMapper
    {
        public static Response.Company MapCompany(Database.Company source)
        {
            return new Response.Company
            {
                 CompanyName = source.Name,
                  IsActive = source.Active,
            };
        }
    }
}
