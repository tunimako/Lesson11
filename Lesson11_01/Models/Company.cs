using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class Company
    {
        public int CompanyID { get; set; }
        public string OwnerCompanyName { get; set; }
        public string CompanyCountryCode { get; set; }

        public Company(int companyID, string ownerCompanyName, string companyCountryCode)
        {
            CompanyID = companyID;
            OwnerCompanyName = ownerCompanyName;
            CompanyCountryCode = companyCountryCode;
        }
    }
}
