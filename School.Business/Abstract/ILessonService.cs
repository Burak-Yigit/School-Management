﻿using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Abstract
{
    public interface ILessonService
    {
        List<Lesson> GetAll();
    }
}
