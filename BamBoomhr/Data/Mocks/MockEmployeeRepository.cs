using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmployeeRepository : IEmployeeRepository
    {



        public IEnumerable<Employee> IEmployees
        {
            get
            {
                return new List<Employee>
                {
                    new Employee {
                        EmployeeId = 187,
                        ImageUrl = "https://www.questionpro.com/blog/wp-content/uploads/2018/09/67-Employee-Morale.jpg",
                        FirstName = "Ben",
                        MiddleName = "Ade",
                        LastName = "Eze",
                        Photography = "",
                        Gender = "Male",
                        Nationality = "Nigeria",
                        MaritalStatus = "Single",
                        DateofBirth = DateTime.Today,
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<Employee> PreferredIEmployees { get; }
        public Employee GetIEmployeeById(int EmployeeId)
        {
            throw new NotImplementedException();
        }
    }
}









