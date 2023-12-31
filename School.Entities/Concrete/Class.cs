﻿using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class Class : IEntity
    {
        public int ClassId { get; set; }
        public int ClassCodeId { get; set; }
        public int GradeID { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual ClassCode ClassCode { get; set; }
    }
}
