using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IJobTitlesRepository
    {

        IEnumerable<JobTitles> JobTitles { get; set; }
        IEnumerable<JobTitles> PreferredJobTitles { get; set; }
        JobTitles GetJobTitlesById(int JobTitlesId);
    }
}
