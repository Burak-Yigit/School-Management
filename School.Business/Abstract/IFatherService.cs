using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Abstract
{
    public interface IFatherService
    {
        List<Father> GetAll();
        void Add(Father father);
        void Update(Father father);
    }
}
