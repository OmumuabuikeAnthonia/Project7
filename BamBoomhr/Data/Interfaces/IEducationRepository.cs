using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IEducationRepository
    {

        IEnumerable<Education> Educations { get; set; }
        IEnumerable<Education> PreferredEducations { get; set; }
        Education GetEducationById(int EducationId);
    }
}
