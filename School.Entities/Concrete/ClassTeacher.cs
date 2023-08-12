using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class ClassTeacher:IEntity
    {
        public int ClassTeacherId { get; set; }
        public int ClassId { get; set; }
        public int EmployeeId { get; set; }
        public int LessonId { get; set; }

    }
}
