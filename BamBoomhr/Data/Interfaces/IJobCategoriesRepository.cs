using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IJobCategoriesRepository
    {

        IEnumerable<JobCategories> JobCategories { get; set; }
        IEnumerable<JobCategories> PreferredJobCategories { get; set; }
        JobCategories GetJobCategoriesById(int JobCategoriesId);
    }
}
