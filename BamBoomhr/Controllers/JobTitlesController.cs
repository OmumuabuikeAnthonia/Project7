using BamBoomhr.Data.Interfaces;
using BamBoomhr.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BamBoomhr.Controllers
{
    public class JobTitlesController : Controller
    {
        private readonly IEmployeeSubordinatesRepository _employeeSubordinatesRepository;
        private readonly IEmployeeSupervisorsRepository _employeeSupervisorsRepository;
        private readonly IEmployeeMembershipsRepository _employeeMembershipsRepository;
        private readonly IEmployeeSalaryRepository _employeeSalaryRepository;
        private readonly IEmployeeJobRepository _employeeJobRepository;
        private readonly IEmployeeImmigrationRepository _employeeImmigrationRepository;
        private readonly IEmployeeDependantRepository _employeeDependantRepository;
        private readonly IEmployeeEmergencyContactRepository _employeeEmergencyContactRepository;
        private readonly IEmployeeContactDetailsRepository _employeeContactDetailsRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly INationalitiesRepository _nationalitiesRepository;
        private readonly IMembershipsRepository _membershipsRepository;
        private readonly ILanguagesRepository _languagesRepository;
        private readonly ILicensesRepository _licensesRepository;
        private readonly IEducationRepository _educationRepository;
        private readonly ISkillsRepository _skillsRepository;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly ICompanyBranchRepository _companyBranchRepository;
        private readonly ICompanyInformationRepository _companyInformationRepository;
        private readonly ICurrenciesRepository _currenciesRepository; 
        private readonly IJobCategoriesRepository _jobCategoriesRepository;
        private readonly IEmploymentStatusRepository _employmentStatus;
        private readonly IPayGradesRepository _payGradesRepository;
        private readonly IJobTitlesRepository _jobTitlesRepository;

        public JobTitlesController(IEmployeeSubordinatesRepository employeeSubordinatesRepository, IEmployeeSupervisorsRepository employeeSupervisorsRepository, IEmployeeMembershipsRepository employeeMembershipsRepository, IEmployeeSalaryRepository employeeSalaryRepository, IEmployeeJobRepository employeeJobRepository, IEmployeeImmigrationRepository employeeImmigrationRepository, IEmployeeDependantRepository employeeDependantRepository, IEmployeeEmergencyContactRepository employeeEmergencyContactRepository, IEmployeeContactDetailsRepository employeeContactDetailsRepository, IEmployeeRepository employeeRepository, INationalitiesRepository nationalitiesRepository, IMembershipsRepository membershipsRepository, ILanguagesRepository languagesRepository, ILicensesRepository licensesRepository, IEducationRepository educationRepository, ISkillsRepository skillsRepository, IDepartmentRepository departmentRepository, ICompanyBranchRepository companyBranchRepository, ICompanyInformationRepository companyInformationRepository, ICurrenciesRepository currenciesRepository, IJobCategoriesRepository jobCategoriesRepository, IEmploymentStatusRepository employmentStatus, IPayGradesRepository payGradesRepository, IJobTitlesRepository jobTitlesRepository)
        {
            _employeeSubordinatesRepository = employeeSubordinatesRepository;
            _employeeSupervisorsRepository = employeeSupervisorsRepository;
            _employeeMembershipsRepository = employeeMembershipsRepository;
            _employeeSalaryRepository = employeeSalaryRepository;
            _employeeJobRepository = employeeJobRepository;
            _employeeImmigrationRepository = employeeImmigrationRepository;
            _employeeDependantRepository = employeeDependantRepository;
            _employeeEmergencyContactRepository = employeeEmergencyContactRepository;
            _employeeContactDetailsRepository = employeeContactDetailsRepository;
            _employeeRepository = employeeRepository;
            _nationalitiesRepository = nationalitiesRepository;
            _membershipsRepository = membershipsRepository;
            _languagesRepository = languagesRepository;
            _licensesRepository = licensesRepository;
            _educationRepository = educationRepository;
            _skillsRepository = skillsRepository;
            _departmentRepository = departmentRepository;
            _companyBranchRepository = companyBranchRepository;
            _companyInformationRepository = companyInformationRepository;
            _currenciesRepository = currenciesRepository;
            _jobCategoriesRepository = jobCategoriesRepository;
            _employmentStatus = employmentStatus;
            _payGradesRepository = payGradesRepository;
            _jobTitlesRepository = jobTitlesRepository;
        }
        public ViewResult List()
        {
            ViewBag.JobTitles = "Dotnet, How?";
            var jobTitles = _jobTitlesRepository.JobTitles;
            JobTitlesListViewModel vm = new JobTitlesListViewModel();
            vm.JobTitles = _jobTitlesRepository.JobTitles;
            vm.CurrentCategory = "JobTitlesCategory";
            return View(vm);
        }
    }
}
