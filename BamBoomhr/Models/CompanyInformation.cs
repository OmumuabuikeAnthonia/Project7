using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Models
{
    public class CompanyInformation
    {

        public int Id { get; set; }
        public string OrganizationName { get; set; }
        public int TaxID { get; set; }
        public int NumberOfEmployees { get; set; }
        public string ImageUrl { get; set; }
        public int RegisterationNumber { get; set; }
        public int PhoneNumber { get; set; }
        public int Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserId { get; set; }
    }
}
