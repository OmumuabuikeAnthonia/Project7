using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Interfaces
{
    public interface ICurrenciesRepository
    {

        IEnumerable<Currencies> Currencies { get; set; }
        IEnumerable<Currencies> PreferredCurrencies { get; set; }
        Currencies GetCurrenciesById(int CurrenciesId);
    }
}
