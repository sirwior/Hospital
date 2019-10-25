using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Entities
{
    public class Doctor : BaseEntity
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Category { get; set; }
        public virtual List<Patient> Patients { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual List<Assignment> Assignments { get; set; }
    }
}
