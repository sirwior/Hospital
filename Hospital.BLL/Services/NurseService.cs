using Hospital.BLL.Models;
using System;
using System.Collections.Generic;
using AutoMapper;
using Hospital.DAL.UnitOfWork.Interfaces;
using Hospital.DAL.Entities;

namespace Hospital.BLL.Services
{
    public class NurseService
    {
        private IUnitOfWork _unitOfWork { get; set; }

        public NurseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<GetAllPatientsModel> GetAllPatients()
        {
            var config = new MapperConfiguration(m => m.CreateMap<Patient, GetAllPatientsModel>()).CreateMapper();

            var users = config.Map<IEnumerable<Patient>, List<GetAllPatientsModel>>(_unitOfWork.Patients.GetAll());
            return users;
        }

        public void CreateAssignment(CreateAssignmentModel assignmentModel, int cardId)
        {
            var config = new MapperConfiguration(m => m.CreateMap<CreateAssignmentModel, Assignment>()).CreateMapper();

            var ass = config.Map<CreateAssignmentModel, Assignment>(assignmentModel);
            _unitOfWork.MedicalCards.AddAssignment(cardId, ass);
        }
    }
}
