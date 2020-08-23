using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmployeeDependantRepository : IEmployeeDependantRepository
    {



        public IEnumerable<EmployeeDependant> IEmployeeDependants
        {
            get
            {
                return new List<EmployeeDependant>
                {
                    new EmployeeDependant { 
                        Name = "Susan Eze",
                        Relationship = "Sister",
                        DateofBirth = DateTime.Today,
                        ImageUrl = "https://www.converge.today/files/cms_element_content/image_url/3153/CmsElementContent_5d1c6dbb209ac.jpeg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<EmployeeDependant> PreferredIEmployeeDependants { get; }
        public EmployeeDependant GetIEmployeeDependantById(int EmployeeDependantId)
        {
            throw new NotImplementedException();
        }
    }
}









