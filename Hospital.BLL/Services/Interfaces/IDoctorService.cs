using Hospital.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Services.Interfaces
{
    public interface IDoctorService
    {
        List<GetAllPatientsModel> GetAllPatients();
        void DiagnoseToPatient(int cardId,string diagnoseToPatient);
        void CreateAssignment(CreateAssignmentModel assignmentModel, int cardId);
        void DischargePatient(int patId);
    }
}
