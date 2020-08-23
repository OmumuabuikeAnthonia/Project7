using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEducationRepository : IEducationRepository
    {



        public IEnumerable<Education> IEducations
        {
            get
            {
                return new List<Education>
                {
                    new Education {
                        Name = "Graphic Design",
                        ImageUrl = "https://image.shutterstock.com/image-photo/education-global-world-graduation-cap-260nw-793972774.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<Education> PreferredIEducations { get; }
        public Education GetIEducationById(int EducationId)
        {
            throw new NotImplementedException();
        }
    }
}








