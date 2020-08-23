using BamBoomhr.Data.Interfaces;
using BamBoomhr.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BamBoomhr.Data.Mocks
{
    public interface MockCompanyInformationRepository :ICompanyInformationRepository
    {



        public IEnumerable<CompanyInformation> ICompanyInformation
        {
            get
            {
                return new List<CompanyInformation>
                {
                    new CompanyInformation {
                       OrganizationName = "Cyhermes LTD",
                        TaxID = 2781913,
                        NumberOfEmployees = 20,
                        RegisterationNumber = 54673728,
                        PhoneNumber = 01812736908,
                        Fax = 81234,
                        Email = "cyhermes@outlook.com",
                        Address = "Freedomway Lekki Lagos State",
                        City = "Ikeja",
                        State = "Lagos State",
                        Country = "Nigeria",
                        ZipCode = 197391,
                        ImageUrl = "https://www.cbc.co.jp/en/_shared/images/outline/index_visual_01.png",
                        DateCreated = DateTime.Now,
                        DateModified = DateTime.Today,
                    }
                };
            }
        }
        public IEnumerable<CompanyInformation> PreferredICompanyInformation { get; }
        public CompanyInformation GetICompanyInformationById(int CompantInformationId)
        {
            throw new NotImplementedException();
        }
    }
}









