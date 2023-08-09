using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class Employee:IEntity
    {
        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public int BranchId { get; set; }
        public int PositionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsMarried { get; set; }
        public decimal Salary { get; set; }
        public bool IsEmployee { get; set; }
        public string PhoneNumber { get; set; }
    }
}
