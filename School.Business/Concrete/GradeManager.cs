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
    public class GradeManager : IGradeService
    {
        private IGradeDal _gradeDal;
        public GradeManager(IGradeDal gradeDal)
        {
            _gradeDal = gradeDal;
        }

        public List<Grade> GetAll()
        {
            return _gradeDal.GetAll();
        }

    }
}
