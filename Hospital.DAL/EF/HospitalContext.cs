using Hospital.DAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL
{
    public class HospitalContext : IdentityDbContext<ApplicationUser>
    {
        public HospitalContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<HospitalContext>());
        }
        public HospitalContext(string name) : base(name)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<HospitalContext>());
        }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<MedicalCard> MedicalCards { get; set; }

        public DbSet<Nurse> Nurses { get; set; }

        public DbSet<Patient> Patients { get; set; }
    }
}
