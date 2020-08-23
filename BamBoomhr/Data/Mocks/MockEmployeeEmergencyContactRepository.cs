using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmployeeEmergencyContactRepository : IEmployeeEmergencyContactRepository
    {



        public IEnumerable<EmployeeEmergencyContact> IEmployeeEmergencyContacts
        {
            get
            {
                return new List<EmployeeEmergencyContact>
                {
                    new EmployeeEmergencyContact {
                        Name = "Christ Eze",
                        Relationship = "Father",
                        HomeTelephone = 01654567,
                        Mobile = 090432345,
                        WorkTelephone = 080765678,
                        ImageUrl = "https://greenwaldllp.com/wp-content/uploads/2017/09/emergency-contact.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<EmployeeEmergencyContact> PreferredIEmployeeEmergencyContacts { get; }
        public EmployeeEmergencyContact GetIEmployeeEmergencyContactById(int EmployeeEmergencyContactId)
        {
            throw new NotImplementedException();
        }
    }
}









