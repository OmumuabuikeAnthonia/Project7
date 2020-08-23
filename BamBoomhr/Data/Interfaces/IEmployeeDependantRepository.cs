using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEmployeeDependantRepository
    {

        IEnumerable<EmployeeDependant> EmployeeDependants { get; set; }
        IEnumerable<EmployeeDependant> PreferredEmployeeDependants { get; set; }
        EmployeeDependant GetEmployeeDependantById(int EmployeeDependantId);
    }
}
