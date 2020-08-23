using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface ILicensesRepository
    {

        IEnumerable<Licenses> Licenses { get; set; }
        IEnumerable<Licenses> PreferredLicenses { get; set; }
        Licenses GetLicensesById(int LicensesId);
    }
}
