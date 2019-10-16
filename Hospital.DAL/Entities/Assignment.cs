using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Entities
{
    public class Assignment : BaseEntity
    {
        public string Title { get; set; }
        public string Procedures { get; set; }
        public string Medicines { get; set; }
        public string Surgery { get; set; }
        public DateTime Date { get; set; }

        //Должностное лицо, выполнившее назначение(Assignment).
        public string Official { get; set; } 
    }
}
