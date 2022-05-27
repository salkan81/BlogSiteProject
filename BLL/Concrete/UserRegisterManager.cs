using BLL.Abstract;
using Core.Concrete;
using DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class UserRegisterManager : IUserRegisterService
    {
        IUserRegisterDal _userRegisterDal;

        public UserRegisterManager(IUserRegisterDal userRegisterDal)
        {
            _userRegisterDal = userRegisterDal;
        }
        public bool Add(UserRegister entity)
        {
            return _userRegisterDal.Add(entity);
        }

        public bool Delete(UserRegister entity)
        {
            return _userRegisterDal.Delete(entity);
        }

        public IEnumerable<UserRegister> GetAll()
        {
            return _userRegisterDal.GetAll();
        }

        public UserRegister GetByEmailAndPassword(string email, string password)
        {
            return _userRegisterDal.GetByEmailAndPassword(email, password);
        }

        public UserRegister GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(UserRegister entity)
        {
            return _userRegisterDal.Update(entity);
        }
    }
}
