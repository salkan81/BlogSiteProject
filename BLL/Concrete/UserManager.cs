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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal) 
        {
            _userDal = userDal;
        }
        public bool Add(User entity)
        {
            return _userDal.Add(entity);
        }

        public bool Delete(User entity)
        {
            return _userDal.Delete(entity);
        }

        public IEnumerable<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetByID(int id)
        {
            return _userDal.GetById(id);
        }


        public bool Update(User entity)
        {
            return _userDal.Update(entity);
        }
    }
}
