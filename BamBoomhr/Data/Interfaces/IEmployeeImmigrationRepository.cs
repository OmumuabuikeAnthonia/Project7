using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEmployeeImmigrationRepository
    {

        IEnumerable<EmployeeImmigration> EmployeeImmigrations { get; set; }
        IEnumerable<EmployeeImmigration> PreferredEmployeeImmigrations { get; set; }
        EmployeeImmigration GetEmployeeImmigrationById(int EmployeeImmigrationId);
    }
}
