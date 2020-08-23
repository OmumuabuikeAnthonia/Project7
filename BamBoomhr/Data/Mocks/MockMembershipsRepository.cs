using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockMembershipsRepository : IMembershipsRepository
    {



        public IEnumerable<Memberships> IMemberships
        {
            get
            {
                return new List<Memberships>
                {
                    new Memberships {
                        Name = "Graphic Design",
                        ImageUrl = "https://cdn.xl.thumbs.canstockphoto.com/membership-an-illustrated-stamp-that-declares-a-membership-all-on-white-background-drawings_csp3458323.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<Memberships> PreferredIMemberships { get; }
        public Memberships GetIMembershipsById(int MembershipsId)
        {
            throw new NotImplementedException();
        }
    }
}








