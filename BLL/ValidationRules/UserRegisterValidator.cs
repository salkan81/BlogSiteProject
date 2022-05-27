using Core.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ValidationRules
{
    public class UserRegisterValidator:AbstractValidator<UserRegister>
    {
        public UserRegisterValidator()
        {
            RuleFor(a=>a.Email).Matches(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$").WithMessage("Please enter a valid email address").NotEmpty().WithMessage("Please enter email");
            RuleFor(a => a.Password).Matches(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\w\d\s:])([^\s]){8,16}$").WithMessage("Must contain 1 number (0-9), 1 uppercase letter, 1 lowercase letter, 1 non - alpha numeric number, 8 - 16 characters with no space").NotEmpty().WithMessage("Please enter password");
        }
    }
}
