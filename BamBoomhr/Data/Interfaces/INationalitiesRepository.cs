using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface INationalitiesRepository
    {

        IEnumerable<Nationalities> Nationalities { get; set; }
        IEnumerable<Nationalities> PreferredNationalities { get; set; }
        Nationalities NationalitiesById(int NationalitiesId);
    }
}
