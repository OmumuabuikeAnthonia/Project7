using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockNationalitesRepository : INationalitiesRepository
    {



        public IEnumerable<Nationalities> INationalities
        {
            get
            {
                return new List<Nationalities>
                {
                    new Nationalities {
                        CountryName = "Nigeria",
                        ImageUrl = "https://www.english-learn-online.com/wp-content/uploads/nationalities-1.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<Nationalities> PreferredINationalities { get; }
        public Nationalities GetINationalitiesById(int NationalitiesId)
        {
            throw new NotImplementedException();
        }
    }
}





