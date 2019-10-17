using Hospital.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repository.Interfaces
{
    public interface IDoctorRepository : IBaseRepository<Doctor>
    {
        List<Doctor> GetDoctorsSortedByName();

        List<Doctor> GetDoctorsSortedByCategory(string category);

        List<Doctor> GetDoctorsSortedByNumPatients();
    }
}
