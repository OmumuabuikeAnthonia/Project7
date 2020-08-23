using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockSkillsRepository : ISkillsRepository
    {



        public IEnumerable<Skills> ISkills
        {
            get
            {
                return new List<Skills>
                {
                    new Skills {
                        Name = "Graphic Design",
                        ImageUrl = "https://image.shutterstock.com/image-vector/skill-levels-knob-button-increasing-260nw-1484062181.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<Skills> PreferredISkills { get; }
        public Skills GetISkillsById(int SkillsId)
        {
            throw new NotImplementedException();
        }
    }
}









