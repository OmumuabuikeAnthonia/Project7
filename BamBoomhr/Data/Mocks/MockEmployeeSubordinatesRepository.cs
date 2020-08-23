using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmployeeSubordinatesRepository : IEmployeeSubordinatesRepository
    {



        public IEnumerable<EmployeeSubordinates> IEmployeeSubordinates
        {
            get
            {
                return new List<EmployeeSubordinates>
                {
                    new EmployeeSubordinates {
                        Name = "Eva Daniels",
                        ReportingMethod = "Indirect",
                        ImageUrl = "https://s3-ap-southeast-2.amazonaws.com/geg-gug-webapp/images/1557364192-work_while_you_study_banner.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<EmployeeSubordinates> PreferredIEmployeeSubordinates { get; }
        public EmployeeSubordinates GetIEmployeeSubordinatesById(int EmployeeSubordinatesId)
        {
            throw new NotImplementedException();
        }
    }
}








