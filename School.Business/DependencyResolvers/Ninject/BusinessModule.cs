using Ninject.Modules;
using School.Business.Abstract;
using School.Business.Concrete;
using School.DataAccess.Abstract;
using School.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthenticatorService>().To<AuthenticatorManager>();
            Bind<IAuthenticatorDal>().To<EfAuthenticatorDal>();
            
            Bind<IFatherService>().To<FatherManager>();
            Bind<IFatherDal>().To<EfFatherDal>();

            Bind<IMotherService>().To<MotherManager>();
            Bind<IMotherDal>().To<EfMotherDal>();

            Bind<IRelationService>().To<RelationManager>();
            Bind<IRelationDal>().To<EfRelationDal>();
        }
    }
}
