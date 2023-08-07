using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class Branch :IEntity
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchDescription { get; set; }
    }
}
