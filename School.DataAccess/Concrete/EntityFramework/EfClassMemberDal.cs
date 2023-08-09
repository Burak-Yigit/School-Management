using School.DataAccess.Abstract;
using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Concrete.EntityFramework
{
    public class EfClassMemberDal : EfEntityRepositoryBase<ClassMember, SchoolContext>, IClassMemberDal
    {
    }
}
