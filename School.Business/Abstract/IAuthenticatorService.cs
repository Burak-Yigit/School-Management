using School.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Business.Abstract
{
    public interface IAuthenticatorService
    {
        List<User> GetAll();
        User Authenticate(string username, string password);
    }
}
