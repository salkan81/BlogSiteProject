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
    public class UserRepositoryDal : GenericRepository<User>, IUserDal
    {
        private readonly ApplicationDbContext db;

        public UserRepositoryDal(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public User GetById(int id)
        {
            return db.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}
