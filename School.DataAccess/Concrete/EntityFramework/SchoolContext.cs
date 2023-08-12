using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DataAccess.Concrete.EntityFramework
{
    public class SchoolContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Mother> Mothers { get; set; }
        public DbSet<Father> Fathers { get; set; }
        public DbSet<Relation> Relations { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassMember> ClassMembers { get; set; }
        public DbSet<ClassTeacher> ClassTeachers { get; set; }
        public DbSet<ClassCode> ClassCodes { get; set; }    

    }
}
