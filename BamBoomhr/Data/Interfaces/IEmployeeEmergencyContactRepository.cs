using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEmployeeEmergencyContactRepository
    {

        IEnumerable<EmployeeEmergencyContact> EmployeeEmergencyContacts { get; set; }
        IEnumerable<EmployeeEmergencyContact> PreferredEmployeeEmergencyContacts { get; set; }
        EmployeeEmergencyContact GetEmployeeEmergencyContactById(int EmployeeEmergencyContactId);
    }
}
