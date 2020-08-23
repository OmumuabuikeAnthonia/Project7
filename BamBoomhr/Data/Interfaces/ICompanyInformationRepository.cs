using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface ICompanyInformationRepository
    {

        IEnumerable<CompanyInformation> CompanyInformation { get; set; }
        IEnumerable<CompanyInformation> PreferredCompanyInformation { get; set; }
        CompanyInformation GetCompanyInformationById(int CompanyInformationId);
    }
}
