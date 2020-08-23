using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Models
{
    public class EmployeeImmigration
    {

        public int Id { get; set; }
        public string DocumentType { get; set; }
        public string ImageUrl { get; set; }
        public int Number { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string EligibleStatus { get; set; }
        public int IssuedBy { get; set; }
        public DateTime ElligibleReviewDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserId { get; set; }
    }
}
