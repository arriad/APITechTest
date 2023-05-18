using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARiad.APITech.Application.Models
{
    internal class Claim
    {
        public string ClaimId { get; set; }
        public int CompanyID { get; set; }
        public int? ClaimAgeInDays { get;set; }
    }
}
