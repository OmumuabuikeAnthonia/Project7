using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IPayGradesRepository
    {

        IEnumerable<PayGrades> PayGrades { get; set; }
        IEnumerable<PayGrades> PreferredPayGrades { get; set; }
        PayGrades GetPayGradesById(int PayGradesId);
    }
}
