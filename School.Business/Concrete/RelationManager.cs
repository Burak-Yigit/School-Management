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
    public class RelationManager : IRelationService
    {
        private IRelationDal _relationDal;
        public RelationManager(IRelationDal relationDal)
        {
            _relationDal = relationDal;
        }

        public void AddRelation(Relation relation)
        {
            _relationDal.Add(relation);
        }

        public List<Relation> GetAll()
        {
            return _relationDal.GetAll();
        }

        public bool RelationExists(int motherID, int fatherID)
        {
            return _relationDal.GetAll().Any(r=>r.MotherID==motherID || r.FatherID==fatherID);
        }
    }
}
