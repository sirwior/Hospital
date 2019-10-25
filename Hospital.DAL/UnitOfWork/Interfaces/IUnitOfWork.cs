using Hospital.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAssignmentRepository Assignments { get; }
        IDoctorRepository Doctors { get; }
        IMedicalCardRepository MedicalCards { get; }
        INurseRepository Nurses { get; }
        IPatientRepository Patients { get; }
        void Save();
    }
}
