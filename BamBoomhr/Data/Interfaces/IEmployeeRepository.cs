using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEmployeeRepository
    {

        IEnumerable<Employee> Employees { get; set; }
        IEnumerable<Employee> PreferredEmployees { get; set; }
        Employee GetEmployeeById(int EmployeeId);
    }
}
