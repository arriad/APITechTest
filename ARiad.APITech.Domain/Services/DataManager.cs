using ARiad.APITech.Application.Interfaces;
using ARiad.APITech.Application.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace ARiad.APITech.Infrastructure.Services
{
    public class DataManager : IDataManager
    {
        
       async Task<Company> IDataManager.GetCompany(int companyId)
        {

            string companiesJson = await File.ReadAllTextAsync("./Companies/Companies.json");
            List<Company> companies = JsonConvert.DeserializeObject<List<Company>>(companiesJson);

            return companies.FirstOrDefault(b => b.Id == companyId);
        }

        async Task<List<Claim>> IDataManager.GetClaims(int companyId)
        {

            string claimsJson = await File.ReadAllTextAsync("./Claims/Claims.json");
            List<Claim> claims = JsonConvert.DeserializeObject<List<Claim>>(claimsJson);

            return claims.Where(b=>b.CompanyID==companyId)?.ToList();

        }

        async Task<Claim> IDataManager.GetClaim(string claimId)
        {
            string claimsJson = await File.ReadAllTextAsync("./claims/Claims.json");
            List<Claim> claims = JsonConvert.DeserializeObject<List<Claim>>(claimsJson);

            return claims.FirstOrDefault(b => b.UCR == claimId);
        }
    }
}
