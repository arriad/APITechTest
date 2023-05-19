using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARiad.APITech.Application.Models.Database
{
    public class Claim
    {
        public string UCR { get; set; }
        public int CompanyID { get; set; }
        public DateTime? ClaimDate { get; set; }
        public DateTime? LossDate { get; set; }
        public string AssuredName { get; set; }
        public decimal? IncurredLoss { get; set; }
        public bool Closed { get; set; }
    }
}
