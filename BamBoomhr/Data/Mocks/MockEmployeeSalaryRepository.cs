using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmployeeSalaryRepository : IEmployeeSalaryRepository

    {



        public IEnumerable<EmployeeSalary> IEmployeeSalaries
        {
            get
            {
                return new List<EmployeeSalary>
                {
                    new EmployeeSalary {
                        PayGradeId = 2341,
                        PayFrequency = "Monthly",
                        Currency = Decimal.MaxValue,
                        Amount = Decimal.MaxValue,
                        ImageUrl = "https://www.ricoh-europe.com/media/Future%20of%20Work%20-%20Thumbnail%201_tcm100-36227.png",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<EmployeeSalary> PreferredIEmployeeSalaries { get; }
        public EmployeeSalary GetIEmployeeSalaryById(int EmployeeSalaryId)
        {
            throw new NotImplementedException();
        }
    }
}








