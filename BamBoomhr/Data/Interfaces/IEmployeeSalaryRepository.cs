using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEmployeeSalaryRepository
    {

        IEnumerable<EmployeeSalary> EmployeeSalaries { get; set; }
        IEnumerable<EmployeeSalary> PreferredEmployeeSalaries { get; set; }
        EmployeeSalary GetEmployeeSalaryById(int EmployeeSalaryId);
    }
}
