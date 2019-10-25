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
    public class MedicalCardRepository : BaseRepository<MedicalCard>, IMedicalCardRepository
    {
        private readonly HospitalContext _context;

        public MedicalCardRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public void AddAssignment(int id, Assignment assignment)
        {
            var medCard = _context.MedicalCards
                          .Where(m => m.Id == id)
                          .FirstOrDefault();
            medCard.Assignments.Add(assignment);
            _context.SaveChanges();
        }

        public void AddDoctor(int patId, int docId)
        {
            var medCard = _context.MedicalCards
                          .Where(m => m.Id == patId)
                          .FirstOrDefault();
            medCard.DoctorId = docId;
            _context.SaveChanges();
        }

        public void DiagnosePatient(int id, string diagnose)
        {
            var medCard = _context.MedicalCards
                          .Where(m => m.Id == id)
                          .FirstOrDefault();

            medCard.Diagnosis = diagnose;

            _context.SaveChanges();
        }
    }
}
