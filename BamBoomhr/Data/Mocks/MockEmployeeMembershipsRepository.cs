using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmployeeMembershipsRepository : IEmployeeMembershipsRepository
    {



        public IEnumerable<EmployeeMemberships> IEmployeeMemberships
        {
            get
            {
                return new List<EmployeeMemberships>
                {
                    new EmployeeMemberships {
                        Name = "Ben Ade Eze",
                        ReportingMethod = "Direct",
                        ImageUrl = "https://www.cv-library.co.uk/career-advice/wp-content/uploads/2018/06/What-is-it-like-working-in-IT.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<EmployeeMemberships> PreferredIEmployeeMemberships { get; }
        public EmployeeMemberships GetIEmployeeMembershipsById(int EmployeeMembershipsId)
        {
            throw new NotImplementedException();
        }
    }
}








