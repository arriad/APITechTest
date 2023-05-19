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
        public static Response.Claim MapClaim(Database.Claim source)
        {

            return new Response.Claim
            {
                 ClaimId=source.UCR,
                  CompanyID=source.CompanyID,
                   ClaimAgeInDays=CalculateNumberOfDaysFromToday(source.ClaimDate)
            };
        }
        public static List<Response.Claim> MapClaims(List<Database.Claim> source)
        {
            List<Response.Claim> claims = new List<Response.Claim>();
            foreach (Database.Claim claim in source) { 
                claims.Add(MapClaim(claim))
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
