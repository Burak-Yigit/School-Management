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
    public class PositionManager :IPositionService
    {
        private IPositionDal _positionDal;
        public PositionManager(IPositionDal positionDal)
        {
            _positionDal = positionDal;
        }

        public List<Position> GetAll()
        {
            return _positionDal.GetAll();
        }
    }
}
