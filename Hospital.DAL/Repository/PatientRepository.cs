using Hospital.DAL.Entities;
using Hospital.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repository
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        private readonly HospitalContext _context;

        public PatientRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public List<Patient> GetPatientsSortedByBirthDate()
        {
            var list = (from patient in _context.Set<Patient>()
                        orderby patient.BirthDate
                        select patient).ToList();
            return list;
        }

        public List<Patient> GetPatientsSortedByName()
        {
            var list = (from patient in _context.Set<Patient>()
                        orderby patient.Surname, patient.Name
                        select patient).ToList();
            return list;
        }
    }
}
