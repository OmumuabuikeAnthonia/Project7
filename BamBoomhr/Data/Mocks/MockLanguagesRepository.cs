using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockLanguagesRepository : ILanguagesRepository

    {



        public IEnumerable<Languages> ILanguages
        {
            get
            {
                return new List<Languages>
                {
                    new Languages {
                        Name = "English",
                        ImageUrl = "https://st2.depositphotos.com/1001877/5371/i/450/depositphotos_53712435-stock-photo-e-learning-learning-languages-online.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<Languages> PreferredILanguages { get; }
        public Languages GetILanguagesById(int LanguagesId)
        {
            throw new NotImplementedException();
        }
    }
}








