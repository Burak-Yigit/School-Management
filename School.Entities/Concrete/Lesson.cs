using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class Lesson : IEntity
    {
        public int LessonId { get; set; }
        public string LessonName { get; set; }
    }
}
