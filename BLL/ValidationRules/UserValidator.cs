using Core.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ValidationRules
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {

        }
    }
}
