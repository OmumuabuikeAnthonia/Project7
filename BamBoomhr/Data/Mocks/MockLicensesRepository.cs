using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockLicensesRepository : ILicensesRepository
    { 


        public IEnumerable<Licenses> ILicenses
        {
            get
            {
                return new List<Licenses>
                {
                    new Licenses {
                        Name = "Graphic Designer",
                        ImageUrl = "https://www.synopsys.com/blogs/software-security/wp-content/uploads/2020/04/5-types-of-software-licenses-2020-2.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<Licenses> PreferredILicenses { get; }
        public Licenses GetILicensesById(int LicensesId)
        {
            throw new NotImplementedException();
        }
    }
}








