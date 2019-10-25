using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Entities
{
    public class MedicalCard : BaseEntity
    {
        [Key]
        public int PatientId { get; set; }

        public virtual Patient Patient { get; set; }

        public int DoctorId { get; set; }
        
        public virtual Doctor Doctor { get; set; }
        public string Diagnosis { get; set; }
        public virtual List<Assignment> Assignments { get; set; }
    }
}
