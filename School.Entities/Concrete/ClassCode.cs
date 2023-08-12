using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class ClassCode :IEntity
    {
        public int ClassCodeId { get; set; }
        public string ClassCodeLetter { get; set; }
    }
}
