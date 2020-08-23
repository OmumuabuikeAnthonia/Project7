using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEmployeeSubordinatesRepository
    {

        IEnumerable<EmployeeSubordinates> EmployeeSubordinates { get; set; }
        IEnumerable<EmployeeSubordinates> PreferredEmployeeSubordinates { get; set; }
        EmployeeSubordinates GetEmployeeSubordinatesById(int EmployeeSubordinatesId);
    }
}
