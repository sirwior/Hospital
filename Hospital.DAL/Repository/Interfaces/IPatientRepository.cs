using Hospital.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repository.Interfaces
{
    public interface IPatientRepository : IBaseRepository<Patient>
    {
        List<Patient> GetPatientsSortedByName();
        List<Patient> GetPatientsSortedByBirthDate();
    }
}
