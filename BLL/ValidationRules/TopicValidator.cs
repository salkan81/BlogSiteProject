﻿using Core.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ValidationRules
{
    public class TopicValidator:AbstractValidator<Topic>
    {
        public TopicValidator()
        {

        }
    }
}
