using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Models
{
    public class EmployeeEmergencyContact
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Relationship { get; set; }
        public int HomeTelephone { get; set; }
        public int Mobile { get; set; }
        public int WorkTelephone { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int UserId { get; set; }
    }
}
