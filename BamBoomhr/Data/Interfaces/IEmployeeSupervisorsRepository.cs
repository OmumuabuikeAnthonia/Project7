using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEmployeeSupervisorsRepository
    {

        IEnumerable<EmployeeSupervisors> EmployeeSupervisors { get; set; }
        IEnumerable<EmployeeSupervisors> PreferredEmployeeSupervisors { get; set; }
        EmployeeSupervisors GetEmployeeSupervisorsById(int EmployeeSupervisorsId);
    }
}
