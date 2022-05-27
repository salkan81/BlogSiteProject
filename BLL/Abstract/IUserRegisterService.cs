using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IUserRegisterService:IGenericService<UserRegister>
    {
        UserRegister GetByEmailAndPassword(string email, string password);
    }
}
