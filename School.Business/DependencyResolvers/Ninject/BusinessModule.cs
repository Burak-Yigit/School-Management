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

            Bind<IStudentService>().To<StudentManager>();
            Bind<IStudentDal>().To<EfStudentDal>();
            Bind<IEmployeeService>().To<EmployeeManager>();
            Bind<IEmployeeDal>().To<EfEmployeeDal>();

            Bind<IBranchService>().To<BranchManager>();
            Bind<IBranchDal>().To<EfBranchDal>();

            Bind<IDepartmentService>().To<DepartmentManager>();
            Bind<IDepartmentDal>().To<EfDepartmentDal>();

            Bind<IPositionService>().To<PositionManager>();
            Bind<IPositionDal>().To<EfPositionDal>();

            Bind<IClassService>().To<ClassManager>();
            Bind<IClassDal>().To<EfClassDal>();

            Bind<IClassTeacherService>().To<ClassTeacherManager>();
            Bind<IClassTeacherDal>().To<EfClassTeacherDal>();

            Bind<IClassMemberService>().To<ClassMemberManager>();
            Bind<IClassMemberDal>().To<EfClassMemberDal>();

            Bind<IGradeService>().To<GradeManager>();
            Bind<IGradeDal>().To<EfGradeDal>();

            Bind<IClassCodeService>().To<ClassCodeManager>();
            Bind<IClassCodeDal>().To<EfClassCodeDal>();
        }
    }
}
