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
    public class FatherManager : IFatherService
    {
        private IFatherDal _fatherDal;
        public FatherManager(IFatherDal fatherDal)
        {
            _fatherDal = fatherDal;
        }

        public void Add(Father father)
        {
            _fatherDal.Add(father);
        }
        public void Update(Father father)
        {
            _fatherDal.Update(father);
        }

        public List<Father> GetAll()
        {
            return _fatherDal.GetAll();
        }

        
    }
}
