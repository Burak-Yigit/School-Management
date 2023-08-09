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
    public class ClassManager :IClassService
    {
        private IClassDal _classDal;
        public ClassManager(IClassDal classDal)
        {
            _classDal = classDal;
        }

        public List<Class> GetAll()
        {
            return _classDal.GetAll();
        }
    }
}
