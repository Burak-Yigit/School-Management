using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal:EfEntityRepositoryBase<Employee,SchoolContext>, IEmployeeDal
    {
    }
}
