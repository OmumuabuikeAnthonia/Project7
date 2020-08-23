using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Models
{
    public class EmployeeJob
    {

        public int Id { get; set; }
        public int JobTitleId { get; set; }
        public string ImageUrl { get; set; }
        public int EmploymentStatusId { get; set; }
        public int JobCategoryId { get; set; }
        public DateTime JoinedDate { get; set; }
        public int DepartmentId { get; set; }
        public int CompanyBranchId { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserId { get; set; }
    }
}
