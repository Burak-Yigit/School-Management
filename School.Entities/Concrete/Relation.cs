using School.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Entities.Concrete
{
    public class Relation : IEntity
    {
        public int RelationId { get; set; }
        public int MotherId { get; set; }
        public int FatherId { get; set; }
        [NotMapped]
        public string DisplayText { get; set; }
    }
}
