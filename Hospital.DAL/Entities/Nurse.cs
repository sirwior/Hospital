using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Entities
{
    public class Nurse : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
