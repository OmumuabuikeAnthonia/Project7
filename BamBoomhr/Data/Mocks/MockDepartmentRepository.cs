using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockDepartmentRepository : IDepartmentRepository
    {



        public IEnumerable<Department> IDepartments
        {
            get
            {
                return new List<Department>
                {
                    new Department {
                        Name = "IT",
                        ImageUrl = "https://www.hamiltoncounty.org/departments/images/400wimages_Departments.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<Department> PreferredIDepartments { get; }
        public Department GetIDepartmentById(int DepartmentId)
        {
            throw new NotImplementedException();
        }
    }
}









