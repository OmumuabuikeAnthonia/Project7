using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmployeeJobRepository : IEmployeeJobRepository
    {



        public IEnumerable<EmployeeJob> IEmployeeJobs
        {
            get
            {
                return new List<EmployeeJob>
                {
                    new EmployeeJob {
                        JobTitleId = 12,
                        EmploymentStatusId = 234,
                        JobCategoryId = 876,
                        JoinedDate = DateTime.Now,
                        DepartmentId = 8765,
                        CompanyBranchId = 876,
                        ContractStartDate = DateTime.Now,
                        ContractEndDate = DateTime.Today,
                        ImageUrl = "https://cached.imagescaler.hbpl.co.uk/resize/scaleWidth/743/cached.offlinehbpl.hbpl.co.uk/news/OMC/WFH-2019092007545320.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<EmployeeJob> PreferredIEmployeeJobs { get; }
        public EmployeeJob GetIEmployeeJobById(int EmploeeJobId)
        {
            throw new NotImplementedException();
        }
    }
}








