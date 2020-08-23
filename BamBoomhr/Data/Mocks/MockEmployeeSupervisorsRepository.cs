using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmployeeSupervisorsRepository : IEmployeeSupervisorsRepository
    {



        public IEnumerable<EmployeeSupervisors> IEmployeeSupervisors
        {
            get
            {
                return new List<EmployeeSupervisors>
                {
                    new EmployeeSupervisors {
                        Name = "Abu Musa",
                        ReportingMethod = "Direct",
                        ImageUrl = "https://bitaml.com/wp-content/uploads/2019/06/business-meeting-1557432992654.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<EmployeeSupervisors> PreferredIEmployeeSupervisors { get; }
        public EmployeeSupervisors GetIEmployeeSupervisorsById(int EmployeeSupervisorsId)
        {
            throw new NotImplementedException();
        }
    }
}








