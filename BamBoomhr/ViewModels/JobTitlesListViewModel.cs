using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.ViewModels
{
    public class JobTitlesListViewModel
    {
        public IEnumerable<JobTitles>JobTitles { get; set; }
        public string CurrentCategory { get; set; }
    }
}
