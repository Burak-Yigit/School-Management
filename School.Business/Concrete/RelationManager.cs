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

        public int GetRelationId(int motherId, int fatherId)
        {
            var relationEntity = _relationDal.Get(p => p.MotherId == motherId && p.FatherId == fatherId);
            if (relationEntity == null)
            {
                throw new Exception("Belirtilen anne ve baba ID'lerine sahip bir ilişki bulunamadı.");
            }
            return relationEntity.RelationId;
        }

        public bool RelationExists(int motherID, int fatherID)
        {
            return _relationDal.GetAll().Any(r=>r.MotherId==motherID || r.FatherId==fatherID);
        }
    }
}
