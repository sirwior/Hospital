using AutoMapper;
using Hospital.BLL.Models;
using Hospital.BLL.Services.Interfaces;
using Hospital.DAL.Entities;
using Hospital.DAL.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Services
{
    public class AdminService : IAdminService
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public AdminService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreatePatient(CreatePatientModel patientModel)
        {
            
        }

        public List<GetAllPatientsModel> GetAllPatients()
        {
            var config = new MapperConfiguration(m => m.CreateMap<Patient, GetAllPatientsModel>()).CreateMapper();
            var users = config.Map<IEnumerable<Patient>, List<GetAllPatientsModel>>(_unitOfWork.Patients.GetAll());
            return users;
        }

        public List<GetAllPatientsModel> GetPatientsSortedByName()
        {
            var config = new MapperConfiguration(m => m.CreateMap<Patient, GetAllPatientsModel>()).CreateMapper();
            var users = config.Map<IEnumerable<Patient>, List<GetAllPatientsModel>>(_unitOfWork.Patients.GetPatientsSortedByName());
            return users;
        }

        public List<GetAllPatientsModel> GetPatientsSortedByBirthDate()
        {
            var config = new MapperConfiguration(m => m.CreateMap<Patient, GetAllPatientsModel>()).CreateMapper();
            var users = config.Map<IEnumerable<Patient>, List<GetAllPatientsModel>>(_unitOfWork.Patients.GetPatientsSortedByBirthDate());
            return users;
        }

        public void DischargePatient(int patId)
        {
            _unitOfWork.Patients.DischargePatient(patId);
        }

        public List<GetAllNursesModel> GetNursesSortedByName()
        {
            var config = new MapperConfiguration(m => m.CreateMap<Nurse, GetAllNursesModel>()
            .ForMember("Name", opt => opt.MapFrom(c => c.Name))
            .ForMember("Surname", opt => opt.MapFrom(c => c.Surname))).CreateMapper();

            var users = config.Map<IEnumerable<Nurse>, List<GetAllNursesModel>>(_unitOfWork.Nurses.GetNursesSortedByName());
            return users;
        }

        public List<GetAllDoctorsModel> GetDoctorsSortedByName()
        {
            var config = new MapperConfiguration(m => m.CreateMap<Doctor, GetAllDoctorsModel>()
            .ForMember("Name", opt => opt.MapFrom(c => c.Name))
            .ForMember("Surname", opt => opt.MapFrom(c => c.Surname))
            .ForMember("Category", opt => opt.MapFrom(c => c.Category))).CreateMapper();

            var users = config.Map<IEnumerable<Doctor>, List<GetAllDoctorsModel>>(_unitOfWork.Doctors.GetDoctorsSortedByName());
            return users;
        }

        public List<GetAllDoctorsModel> GetDoctorsSortedByCategory(string category)
        {
            var config = new MapperConfiguration(m => m.CreateMap<Doctor, GetAllDoctorsModel>()
            .ForMember("Name", opt => opt.MapFrom(c => c.Name))
            .ForMember("Surname", opt => opt.MapFrom(c => c.Surname))
            .ForMember("Category", opt => opt.MapFrom(c => c.Category))).CreateMapper();

            var users = config.Map<IEnumerable<Doctor>, List<GetAllDoctorsModel>>(_unitOfWork.Doctors.GetDoctorsSortedByCategory(category));
            return users;
        }

        public List<GetAllDoctorsModel> GetDoctorsSortedByNumPatients()
        {
            throw new NotImplementedException();
        }

        public void AddDoctorToPatient(int patId, int docId)
        {
            _unitOfWork.MedicalCards.AddDoctor(patId, docId);
        }
    }
}
