using School.DataAccess.Abstract;
using School.Entities.Abstract;
using School.Entities.Concrete;

namespace School.DataAccess.Concrete.EntityFramework
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
    }
}