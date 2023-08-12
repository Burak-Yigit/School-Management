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
    public class ClassManager :IClassService
    {
        private IClassDal _classDal;
        public ClassManager(IClassDal classDal)
        {
            _classDal = classDal;
        }

        public void Add(Class classes)
        {
            _classDal.Add(classes);
        }

        public List<Class> GetAll()
        {
            return _classDal.GetAll();
        }
        public Class Check (int classCodeId,int gradeId)
        {
            var checkClass = _classDal.GetAll().FirstOrDefault(u => u.ClassCodeId == classCodeId && u.GradeID == gradeId);
            return checkClass;
        }

        public int GetClassId(int classCodeId, int GradeId)
        {
            var classEntity = _classDal.Get(p => p.GradeID == GradeId && p.ClassCodeId == classCodeId);
            return classEntity.ClassId;
        }
    }
}
