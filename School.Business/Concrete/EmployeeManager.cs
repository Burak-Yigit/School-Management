using School.Business.Abstract;
using School.DataAccess.Abstract;
using School.DataAccess.Concrete.EntityFramework;
using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee employee)
        {
           _employeeDal.Add(employee);
        }

        public List<Employee> GetAll()
        {
           return _employeeDal.GetAll();
        }
    }
}
