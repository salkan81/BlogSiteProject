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
    public class UsersAndTopicsManager : IUsersAndTopicsService
    {
        private readonly IUsersAndTopicsDal _usersAndTopicsDal;

        public UsersAndTopicsManager(IUsersAndTopicsDal usersAndTopicsDal)
        {
            _usersAndTopicsDal = usersAndTopicsDal;
        }
        public bool Add(UsersAndTopics entity)
        {
            return _usersAndTopicsDal.Add(entity);
        }

        public bool Delete(UsersAndTopics entity)
        {
            return _usersAndTopicsDal.Delete(entity);
        }

        public IEnumerable<UsersAndTopics> GetAll()
        {
            return _usersAndTopicsDal.GetAll();
        }

        public UsersAndTopics GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(UsersAndTopics entity)
        {
            return _usersAndTopicsDal.Update(entity);
        }
    }
}
