using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class Position:IEntity
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; }
    }
}
