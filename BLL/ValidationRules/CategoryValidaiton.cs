using BE.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ValidationRules
{
    public class CategoryValidaiton : AbstractValidator<Category>
    {
        public CategoryValidaiton()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategory ismi boş bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Kategory açklaması boş bırakılamaz");
        }
    }
}
