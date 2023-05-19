using ARiad.APITech.Application.Interfaces;
using Database=ARiad.APITech.Application.Models.Database;
using Response=ARiad.APITech.Application.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARiad.APITech.Application.Mappers;

namespace ARiad.APITech.Application.Services
{
    public class DataManagerService
    {
        private readonly IDataManager _dataManager;

        public DataManagerService(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public async Task<Response.Company> GetCompany(int copmanyId)
        {
          Database.Company companyRetrieved=  await _dataManager.GetCompany(copmanyId);

            if (companyRetrieved == null)
            {
                return null;
            }

            return CompaniesMapper.MapCompany(companyRetrieved);
        }
        public async Task<Response.ClaimResponse> GetClaim(string ucr)
        {
            Database.Claim claimRetrieved = await _dataManager.GetClaim(ucr);

            if (claimRetrieved == null)
            {
                return null;
            }

            return ClaimsMapper.MapClaim(claimRetrieved);
        }
        public async Task<List<Response.ClaimResponse>> GetClaims(int copmanyId)
        {
            List<Database.Claim> claimsRetrieved = await _dataManager.GetClaims(copmanyId);

            if (claimsRetrieved == null)
            {
                return null;
            }
            return ClaimsMapper.MapClaims(claimsRetrieved);

        }

        public async Task<bool> UpdateClaim(Database.Claim claim)
        {
           return await _dataManager.UpdateClaim(claim);            

        }
    }
}
