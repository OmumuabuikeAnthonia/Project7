using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Models
{
    public class EmployeeSalary
    {

        public int Id { get; set; }
        public int PayGradeId { get; set; }
        public string PayFrequency { get; set; }
        public string ImageUrl { get; set; }
        public Decimal Currency { get; set; }
        public Decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserId { get; set; }
    }
}
