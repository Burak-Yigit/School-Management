using Microsoft.Win32;
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
    public class AuthenticatorManager : IAuthenticatorService
    {
        private IAuthenticatorDal _authenticatorDal;
        public AuthenticatorManager(IAuthenticatorDal authenticatorDal)
        {
            _authenticatorDal = authenticatorDal;
        }
        public List<User> GetAll()
        {
            return (List<User>)_authenticatorDal;
        }

        public User Authenticate(string username, string password)
        {
            var user = _authenticatorDal.GetAll().FirstOrDefault(u => u.Username == username && u.Password == password);
            return user;
        }
    }
}
