using Core.Concrete;
using DAL.Context;
using DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Concrete
{
    public class UsersAndTopicsRepositoryDal : GenericRepository<UsersAndTopics>, IUsersAndTopicsDal
    {
        private readonly ApplicationDbContext db;

        public UsersAndTopicsRepositoryDal(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
