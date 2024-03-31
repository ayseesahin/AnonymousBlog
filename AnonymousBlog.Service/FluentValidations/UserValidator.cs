using System;
using AnonymousBlog.Entity.Entities;
using FluentValidation;

namespace AnonymousBlog.Service.FluentValidations
{
	public class UserValidator : AbstractValidator<AppUser>
	{
		public UserValidator()
		{
            RuleFor(x => x.FirstName)
               .NotEmpty()
               .MinimumLength(3)
               .MaximumLength(50)
               .WithName("İsim");

            RuleFor(x => x.LastName)
               .NotEmpty()
               .MinimumLength(3)
               .MaximumLength(50)
               .WithName("Soyisim");

            RuleFor(x => x.PhoneNumber)
               .NotEmpty()
               .MinimumLength(11)
               .WithName("Telefon Numarası");


        }
	}
}

