using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmploymentStatusRepository : IEmploymentStatusRepository
    {


        public IEnumerable<EmploymentStatus> IEmploymentStatus
        {
            get
            {
                return new List<EmploymentStatus>
                {
                    new EmploymentStatus {
                        Name ="Full - Time",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                        ImageUrl = "https://image.shutterstock.com/image-illustration/employment-status-clipboard-illustration-design-260nw-125946770.jpg",

                    }
                };
            }
        }
        public IEnumerable<EmploymentStatus> PreferredIEmploymentStatus { get; }
        public EmploymentStatus GetIEmploymentStatusById(int EmploymentStatusId)
        {
            throw new NotImplementedException();
        }
    }
}




