using Hospital.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Services.Interfaces
{
    interface IAdminService
    {
        //CreateUser()
        //DeleteUser()
        void CreatePatient(CreatePatientModel patientModel);
        //void CreateDoctor(CreateDoctorModel doctorModel);
        //void CreateNurse(CreateNurseModel nurseModel);

        List<GetAllPatientsModel> GetAllPatients();
        List<GetAllPatientsModel> GetPatientsSortedByName();
        List<GetAllPatientsModel> GetPatientsSortedByBirthDate();
        void DischargePatient(int patId);

        List<GetAllNursesModel> GetNursesSortedByName();

        List<GetAllDoctorsModel> GetDoctorsSortedByName();
        List<GetAllDoctorsModel> GetDoctorsSortedByCategory(string category);
        List<GetAllDoctorsModel> GetDoctorsSortedByNumPatients();

        void AddDoctorToPatient(int patId, int docId);


    }
}
