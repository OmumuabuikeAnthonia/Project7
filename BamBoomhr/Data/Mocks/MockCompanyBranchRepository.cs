using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockCompanyBranchRepository : ICompanyBranchRepository
    {



        public IEnumerable<CompanyBranch> ICompanyBranches
        {
            get
            {
                return new List<CompanyBranch>
                {
                    new CompanyBranch {
                        LocationName = "Lekki Lagos State",
                        City = "Ikeja",
                        Country = "Nigeria",
                        ImageUrl = "https://www.anatc.com/common/img/company/sp/img_kv.png",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<CompanyBranch> PreferredICompanyBranches { get; }
        public CompanyBranch GetICompanyBranchById(int CompanyBranchId)
        {
            throw new NotImplementedException();
        }
    }
}







