using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface ICompanyBranchRepository
    {

        IEnumerable<CompanyBranch> CompanyBranches { get; set; }
        IEnumerable<CompanyBranch> PreferredCompanyBranches { get; set; }
        CompanyBranch GetCompanyBranchById(int CompanybranchId);
    }
}
