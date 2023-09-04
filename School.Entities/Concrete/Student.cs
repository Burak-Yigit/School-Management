using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class Student:IEntity
    {
        public int StudentId { get; set; }
        public int RelationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsGraduated { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Gender { get; set; }
        public bool IsActive { get; set; }

    }
}
