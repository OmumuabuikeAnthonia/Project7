using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockEmployeeContactDetailsRepository : IEmployeeContactDetailsRepository
    {



        public IEnumerable<EmployeeContactDetails> IEmployeeContactDetails
        {
            get
            {
                return new List<EmployeeContactDetails>
                {
                    new EmployeeContactDetails {
                        HomeTelephone = 0181434578,
                        Mobile = 0808765465,
                        WorkTelephone = 0813456788,
                        WorkEmail = "benade@gmail.com",
                        OtherEmail = "benade@yahoo.com",
                        PhoneNumber = 0701234657,
                        Fax = 8767,
                        Email = "benade@gmail.com",
                        Address = "Odunlade Somolu Onipani",
                        City = "Ikeja",
                        State = "Lagos",
                        Country = "Nigeria",
                        ZipCode = 002617,
                        ImageUrl = "https://thumbs.dreamstime.com/b/employee-meeting-broker-estate-agent-contact-to-apartment-signing-document-agreement-171423541.jpg",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<EmployeeContactDetails> PreferredIEmployeeContactDetails { get; }
        public EmployeeContactDetails GetIEmployeeContactDetailsById(int EmployeeContactDetailsId)
        {
            throw new NotImplementedException();
        }
    }
}









