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
    public class ClassTeacherManager:IClassTeacherService
    {
        private IClassTeacherDal _classTeacherDal;
        public ClassTeacherManager(IClassTeacherDal classTeacherDal)
        {
            _classTeacherDal = classTeacherDal;
        }

        public void Add(ClassTeacher classTeacher)
        {
            _classTeacherDal.Add(classTeacher);
        }

        public List<ClassTeacher> GetAll()
        {
            return _classTeacherDal.GetAll();
        }
    }
}
