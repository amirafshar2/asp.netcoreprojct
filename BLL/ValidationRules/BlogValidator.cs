using BE.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Blog başlığı boş bırakılamaz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Blog içeriği boş bırakılamaz");
            RuleFor(x => x.İmage).NotEmpty().WithMessage("Blog Görselini boş bırakılamaz");
            RuleFor(x => x.Title).MaximumLength(150).WithMessage("Lütfen 150 karekterden az veri girin");
            RuleFor(x => x.Content).MaximumLength(10000).WithMessage("Lütfen 10000 karekterden az veri girin");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen 4 karekterden daha fazla veri girin");
            RuleFor(x => x.Content).MinimumLength(500).WithMessage("Lütfen 500 karekterden daha fazla veri girin");

        }

    }
}
