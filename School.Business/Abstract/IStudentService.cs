﻿using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Abstract
{
    public interface IStudentService
    {
        List<Student> GetAll();
        void Add(Student student);
        void Update(Student student);
    }
}
