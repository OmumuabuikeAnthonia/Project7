using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmployeeImmigrationRepository : IEmployeeImmigrationRepository
    {



        public IEnumerable<EmployeeImmigration> IEmployeeImmigrations
        {
            get
            {
                return new List<EmployeeImmigration>
                {
                    new EmployeeImmigration {
                        DocumentType = "Passport",
                        Number = 234125,
                        IssuedDate = DateTime.Today,
                        ExpiryDate = DateTime.Now,
                        EligibleStatus = "Single",
                        IssuedBy = 234,
                        ElligibleReviewDate = DateTime.Now,
                        ImageUrl = "https://st3.depositphotos.com/1044737/17402/i/1600/depositphotos_174024794-stock-photo-welcome-new-employee-colleague-refugees.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<EmployeeImmigration> PreferredIEmployeeImmigrations { get; }
        public EmployeeImmigration GetIEmployeeImmigrationById(int EmployeeImmigrationId)
        {
            throw new NotImplementedException();
        }
    }
}







