using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database=ARiad.APITech.Application.Models.Database;
using Response=ARiad.APITech.Application.Models.Response;

namespace ARiad.APITech.Application.Mappers
{
    public static class ClaimsMapper
    {
        public static Response.ClaimResponse MapClaim(Database.Claim source)
        {

            return new Response.ClaimResponse
            {
                 ClaimId=source.UCR,
                  CompanyID=source.CompanyID,
                   ClaimAgeInDays=CalculateNumberOfDaysFromToday(source.ClaimDate)
            };
        }

        public static List<Response.ClaimResponse> MapClaims(List<Database.Claim> source)
        {
            List<Response.ClaimResponse> claims = new List<Response.ClaimResponse>();
            foreach (Database.Claim claim in source) {
                claims.Add(MapClaim(claim));
            }

            return claims;
        }
            static int CalculateNumberOfDaysFromToday(DateTime? sourceDate)
        {
          TimeSpan? timeSpan=  DateTime.Today - sourceDate;

            if (timeSpan.HasValue)
                return (int)timeSpan.Value.TotalDays;

            return 0;
        }
    }
}
