using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Entities
{
    public class MedicalCard : BaseEntity
    {
        public Patient Patient { get; set; }
        public DateTime IlnessStartDate { get; set; }
        public DateTime? IlnessEndDate { get; set; }
        public Doctor Doctor { get; set; }
        public string Diagnosis { get; set; }
        public virtual List<Assignment> Assignments { get; set; }
    }
}
