using Hospital.DAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.EF
{
    public class HospitalContext : IdentityDbContext<ApplicationUser>
    {
        public HospitalContext() 
        {
            
            Database.SetInitializer(new CreateDatabaseIfNotExists<HospitalContext>());
        }

        public HospitalContext(string name) : base(name)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<HospitalContext>());
            
        }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<MedicalCard> MedicalCards { get; set; }

        public DbSet<Nurse> Nurses { get; set; }

        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MedicalCard>()
                .HasKey(e => e.PatientId);

            
            modelBuilder.Entity<Patient>()
                        .HasRequired(p => p.MedicalCard)
                        .WithRequiredDependent(u => u.Patient);

        }
    }
}
