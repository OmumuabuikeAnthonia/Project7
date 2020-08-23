using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockCurrenciesRepository : ICurrenciesRepository
    {



        public IEnumerable<Currencies> ICurrencies
        {
            get
            {
                return new List<Currencies>
                {
                    new Currencies {
                        Name = "Naira",
                        CurrencyCode = "NGN",
                        ImageUrl = "https://balentine.com/wp-content/uploads/2019/09/fullsizeoutput_40b2-700x394.jpeg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<Currencies> PreferredICurrencies { get; }
        public Currencies GetICurrenciesById(int CurrenciesId)
        {
            throw new NotImplementedException();
        }
    }
}








