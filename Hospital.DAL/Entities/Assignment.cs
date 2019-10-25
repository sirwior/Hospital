using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Entities
{
    public class Assignment : BaseEntity
    {
       
        public string Procedures { get; set; }
        public string Medicines { get; set; }
        public string Surgery { get; set; }
        public DateTime Date { get; set; }

        public virtual MedicalCard MedicalCard { get; set; }

        [ForeignKey("Nurse")]
        public int? NurseId { get; set; }
        public virtual Nurse Nurse { get; set; }

        [ForeignKey("Doctor")]
        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
    }
}
