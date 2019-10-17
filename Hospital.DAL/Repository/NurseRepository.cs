using Hospital.DAL.Entities;
using Hospital.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repository
{
    public class NurseRepository : BaseRepository<Nurse>, INurseRepository
    {
        private readonly HospitalContext _context;
        public NurseRepository(HospitalContext context) : base(context)
        {
            _context = context;
        }

        public List<Nurse> GetNursesSortedByName()
        {
            var list = (from nurse in _context.Set<Nurse>()
                        orderby nurse.Surname, nurse.Name
                        select nurse).ToList();
            return list;
        }
    }
}
