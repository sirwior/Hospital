using Hospital.DAL.EF;
using Hospital.DAL.Entities;
using Hospital.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repository
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        private readonly HospitalContext _context;
        public DoctorRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public List<Doctor> GetDoctorsSortedByCategory(string category)
        {
            var list = (from doc in _context.Set<Doctor>()
                        where doc.Category == category
                        select doc).ToList();
            return list;
        }

        public List<Doctor> GetDoctorsSortedByName()
        {
            var list = (from doc in _context.Set<Doctor>()
                        orderby doc.Surname, doc.Name
                        select doc).ToList();
            return list;
        }

        public List<Doctor> GetDoctorsSortedByNumPatients()
        {
            var list = (from doc in _context.Set<Doctor>()
                        orderby doc.Patients.Count descending
                        select doc).ToList();
            return list;
        }
    }
}
