using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class ClassMember : IEntity
    {
        public int ClassMemberId { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
    }
}
