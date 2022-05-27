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
    public class UserRegisterRepositoryDal : GenericRepository<UserRegister>, IUserRegisterDal
    {
        private readonly ApplicationDbContext db;

        public UserRegisterRepositoryDal(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public UserRegister GetByEmailAndPassword(string email, string password)
        {
           return db.UserRegisters.FirstOrDefault(s=>s.Email==email && s.Password==password);
        }
    }
}
