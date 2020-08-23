using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Models
{
    public class EmployeeContactDetails
    {

        public int Id { get; set; }
        public int HomeTelephone { get; set; }
        public int Mobile { get; set; }
        public int WorkTelephone { get; set; }
        public string WorkEmail { get; set; }
        public string OtherEmail { get; set; }
        public int PhoneNumber { get; set; }
        public int Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ImageUrl { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserId { get; set; }
    }
}
