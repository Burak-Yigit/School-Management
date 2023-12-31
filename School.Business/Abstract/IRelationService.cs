﻿using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Abstract
{
    public interface IRelationService
    {
        List<Relation> GetAll();
        void AddRelation(Relation relation);
        bool RelationExists(int motherID, int fatherID);
        int GetRelationId(int motherId, int fatherId);
    }
}
