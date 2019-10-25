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
    public class DoctorService : IDoctorService
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public DoctorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateAssignment(CreateAssignmentModel assignmentModel, int cardId)
        {
            var config = new MapperConfiguration(m => m.CreateMap<CreateAssignmentModel, Assignment>()).CreateMapper();

            var ass = config.Map<CreateAssignmentModel, Assignment>(assignmentModel);
            _unitOfWork.MedicalCards.AddAssignment(cardId, ass);
        }

        public void DiagnoseToPatient(int cardId, string diagnoseToPatient)
        {
            _unitOfWork.MedicalCards.DiagnosePatient(cardId,diagnoseToPatient);
        }

        public void DischargePatient(int patId)
        {
            _unitOfWork.Patients.DischargePatient(patId);
        }

        public List<GetAllPatientsModel> GetAllPatients()
        {
            var config = new MapperConfiguration(m => m.CreateMap<Patient, GetAllPatientsModel>()).CreateMapper();

            var users = config.Map<IEnumerable<Patient>, List<GetAllPatientsModel>>(_unitOfWork.Patients.GetAll());
            return users;
        }
    }
}
