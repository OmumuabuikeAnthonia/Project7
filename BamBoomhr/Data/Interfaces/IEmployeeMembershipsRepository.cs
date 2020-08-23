using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEmployeeMembershipsRepository
    {

        IEnumerable<EmployeeMemberships> EmployeeMemberships { get; set; }
        IEnumerable<EmployeeMemberships> PreferredEmployeeMemberships { get; set; }
        EmployeeMemberships GetEmployeeMembershipsById(int EmployeeMembershipsId);
    }
}
