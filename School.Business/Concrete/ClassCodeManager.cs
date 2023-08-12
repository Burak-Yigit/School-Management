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
    public class ClassCodeManager : IClassCodeService
    {
        private IClassCodeDal _classCodeDal;
        public ClassCodeManager(IClassCodeDal classCodeDal)
        {
            _classCodeDal = classCodeDal;
        }
        public List<ClassCode> GetAll()
        {
            return _classCodeDal.GetAll();
        }
    }
}
