using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface ISkillsRepository
    {

        IEnumerable<Skills> Skills { get; set; }
        IEnumerable<Skills> PreferredSkills { get; set; }
        Skills GetSkillsById(int SkillsId);
    }
}
