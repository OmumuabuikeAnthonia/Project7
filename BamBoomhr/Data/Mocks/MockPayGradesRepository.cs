using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockPayGradesRepository : IPayGradesRepository
    {


        public IEnumerable<PayGrades> IPayGrades
        {
            get
            {
                return new List<PayGrades>
                {
                    new PayGrades {
                        Name = "Naira",
                        Currency = Decimal.MaxValue,
                        MinimumSalary = Decimal.MaxValue,
                        MaximumSalary = Decimal.MaxValue,
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                        ImageUrl = "https://images.cdn1.stockunlimited.net/illustration/naira-currency_1821515.png",

                    }
                };
            }
        }
        public IEnumerable<PayGrades> PreferredIPayGrades { get; }
        public PayGrades GetIPayGradesById(int PayGradesId)
        {
            throw new NotImplementedException();
        }
    }
}






