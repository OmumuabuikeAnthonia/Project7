using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface IMembershipsRepository
    {

        IEnumerable<Memberships> Memberships { get; set; }
        IEnumerable<Memberships> PreferredMemberships { get; set; }
        Memberships GetMembershipsById(int MembershipsId);
    }
}
