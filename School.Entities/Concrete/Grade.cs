using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class Grade:IEntity
    {
        public int GradeId { get; set; }
        public int GradeNumber { get; set; }
    }
}
