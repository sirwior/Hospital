using Hospital.DAL.EF;
using Hospital.DAL.Repository;
using Hospital.DAL.Repository.Interfaces;
using Hospital.DAL.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HospitalContext _context;

        private IAssignmentRepository _assignments;
        private IDoctorRepository _doctors;
        private IMedicalCardRepository _medicalCards;
        private INurseRepository _nurses;
        private IPatientRepository _patients;

        public UnitOfWork(HospitalContext context)
        {
            _context = context;
        }

        public IAssignmentRepository Assignments
        {
            get
            {
                if (_assignments == null)
                    _assignments = new AssignmentRepository(_context);

                return _assignments;
            }
        }

        public IDoctorRepository Doctors
        {
            get
            {
                if (_doctors == null)
                    _doctors = new DoctorRepository(_context);

                return _doctors;
            }
        }

        public IMedicalCardRepository MedicalCards
        {
            get
            {
                if (_medicalCards == null)
                    _medicalCards = new MedicalCardRepository(_context);

                return _medicalCards;
            }
        }

        public INurseRepository Nurses
        {
            get
            {
                if (_nurses == null)
                    _nurses = new NurseRepository(_context);

                return _nurses;
            }
        }

        public IPatientRepository Patients
        {
            get
            {
                if (_patients == null)
                    _patients = new PatientRepository(_context);

                return _patients;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
