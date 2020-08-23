using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockJobTitlesRepository : IJobTitlesRepository
    {

        public IEnumerable<JobTitles> IJobTitles
        {
            get
            {
                return new List<JobTitles>
                {
                    new JobTitles {
                        Title = "Graphic Designer",
                        Description = "[1] Create visual concepts, using computer software or by hand, to communicate ideas that inspire, inform, and captivate consumers. [2] They develop the overall layout and production design for applications such as advertisements, brochures, magazines, and reports.",
                        ImageUrl = "https://blog.hrps.org/sites/default/files/images/iStock-culture_11-29-18.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
            public IEnumerable<JobTitles> PreferredIJobTitles { get; }
            public JobTitles GetIJobTitlesById(int JobTitlesId)
            {
               throw new NotImplementedException();
        }
    }
}






