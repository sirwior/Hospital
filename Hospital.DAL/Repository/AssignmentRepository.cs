﻿using Hospital.DAL.Entities;
using Hospital.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repository
{
    public class AssignmentRepository : IBaseRepository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository()
        {
        }
    }
}
