using BE.concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			//RuleFor(i => i.Name).NotEmpty().WithMessage("Yazar adı boş geçilemez").MinimumLength(2)
			//	.WithMessage("Lütfen en az 2 karakter girişi yapın")
			//	.MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapın");
			//RuleFor(i => i.Mail).NotEmpty().WithMessage("Mail adı boş geçilemez");
			//RuleFor(i => i.Password)
			//.NotEmpty().WithMessage("Şifre alanı boş geçilemez")
			//.Must(password => password != null && password.Any(char.IsDigit) && password.Any(char.IsLower) && password.Any(char.IsUpper))
			//.WithMessage("Şifre en az bir küçük harf, bir büyük harf ve bir rakam içermelidir");
			
		}
		
	}
}
