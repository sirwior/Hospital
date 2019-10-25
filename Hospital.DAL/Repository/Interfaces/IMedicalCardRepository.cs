using Hospital.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repository.Interfaces
{
    public interface IMedicalCardRepository : IBaseRepository<MedicalCard>
    {
        void DiagnosePatient(int id, string diagnose);
        void AddAssignment(int id, Assignment assignment);
        void AddDoctor(int patId, int docId);

    }
}
