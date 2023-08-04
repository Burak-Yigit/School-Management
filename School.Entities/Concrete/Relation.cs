﻿using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class Relation : IEntity
    {
        public int RelationID { get; set; }
        public int MotherID { get; set; }
        public int FatherID { get; set; }
    }
}
