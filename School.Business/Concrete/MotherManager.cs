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
    public class MotherManager:IMotherService
    {
        private IMotherDal _motherDal;
        public MotherManager(IMotherDal motherDal)
        {
            _motherDal = motherDal;
        }

        public void Add(Mother mother)
        {
            _motherDal.Add(mother);
        }

        public List<Mother> GetAll()
        {
            return _motherDal.GetAll();
        }

        public void Update(Mother mother)
        {
            _motherDal.Update(mother);
        }
    }
}
