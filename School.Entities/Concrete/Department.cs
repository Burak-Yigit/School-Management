﻿using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class Department:IEntity
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
