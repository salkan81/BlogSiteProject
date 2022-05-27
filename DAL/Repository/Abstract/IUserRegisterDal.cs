using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Abstract
{
    public interface IUserRegisterDal:IGenericDal<UserRegister>
    {
        UserRegister GetByEmailAndPassword(string email, string password);  
    }
}
