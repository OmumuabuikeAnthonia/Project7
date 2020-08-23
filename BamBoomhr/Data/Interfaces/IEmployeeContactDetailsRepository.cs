using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEmployeeContactDetailsRepository
    {

        IEnumerable<EmployeeContactDetails> EmployeeContactDetails { get; set; }
        IEnumerable<EmployeeContactDetails> PreferredEmployeeContactDetails { get; set; }
        EmployeeContactDetails EmployeeContactDetailsById(int EmployeeContactDetailsId);
    }
}
