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
    public class BranchManager:IBranchService
    {
       private IBranchDal _branchDal;
        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        public List<Branch> GetAll()
        {
            return _branchDal.GetAll();
        }
    }
}
