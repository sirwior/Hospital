using Hospital.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.BLL.Models
{
    public class CreateAssignmentModel
    {
        
        public string Procedures { get; set; }
        public string Medicines { get; set; }
        public string Surgery { get; set; }
        public DateTime Date { get; set; }
        public string Official { get; set; }

    }
}
