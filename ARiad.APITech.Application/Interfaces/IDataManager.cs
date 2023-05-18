using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARiad.APITech.Application.Models.Database;

namespace ARiad.APITech.Application.Interfaces
{
    public interface IDataManager
    {
        Task<Company> GetCompany(int companyId);
        Task<List<Claim>> GetClaims(int companyId);
        Task<Claim> GetClaim(string claimId);
    }
}
