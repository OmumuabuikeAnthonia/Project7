using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Models
{
    public class JobTitles
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserId { get; set; }

    }
}
