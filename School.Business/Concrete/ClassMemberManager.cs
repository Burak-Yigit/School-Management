using School.Business.Abstract;
using School.DataAccess.Abstract;
using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Concrete
{
    internal class ClassMemberManager:IClassMemberService
    {
        private IClassMemberDal _classMemberDal;
        public ClassMemberManager(IClassMemberDal classMemberDal)
        {
            _classMemberDal = classMemberDal;
        }

        public void Add(ClassMember classMember)
        {
            _classMemberDal.Add(classMember);
        }

        public List<ClassMember> GetAll()
        {
            return _classMemberDal.GetAll();
        }
    }
}
