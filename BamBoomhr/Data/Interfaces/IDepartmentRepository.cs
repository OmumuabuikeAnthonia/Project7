using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IDepartmentRepository
    {

        IEnumerable<Department> Departments { get; set; }
        IEnumerable<Department> PreferredDepartments { get; set; }
        Department GetDepartmentById(int DepartmentId);
    }
}
