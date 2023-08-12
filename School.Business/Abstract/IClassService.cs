using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Abstract
{
    public interface IClassService
    {
        void Add(Class classes);
        List<Class> GetAll();
        Class Check(int classCodeId, int gradeId);
        int GetClassId(int classCodeId, int GradeId);



    }
}
