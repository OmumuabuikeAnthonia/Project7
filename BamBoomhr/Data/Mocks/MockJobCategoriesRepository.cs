using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockJobCategoriesRepository : IJobCategoriesRepository
    {


        public IEnumerable<JobCategories> IJobCategories
        {
            get
            {
                return new List<JobCategories>
                {
                    new JobCategories {
                        Name = "Entry Level",
                        ImageUrl = "https://resources.workable.com/wp-content/uploads/2016/08/eeo_featured.png",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<JobCategories> PreferredIJobCategories { get; }
        public JobCategories GetIJobCategoriesById(int JobCategoriesId)
        {
            throw new NotImplementedException();
        }
    }
}


