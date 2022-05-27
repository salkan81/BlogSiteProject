using Core.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ValidationRules
{
    public class ArticleValidator:AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Başlık kısmı boş olamaz...");
            RuleFor(x => x.Content).MinimumLength(200).WithMessage("Makale içeriği 200 den az olamaz");
        }
    }
}
