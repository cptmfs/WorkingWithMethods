using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().When(c => c.IdentityNumber == "123").WithMessage("Adı boş olamaz");
            RuleFor(c => c.FirstName).NotEmpty().When(c => c.IdentityNumber == "1234").WithMessage("Adı boş olamaz");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Soyadı boş olamaz");
            RuleFor(c => c.IdentityNumber).NotEmpty().WithMessage("TC kimlik numarası boş olamaz");
            RuleFor(c => c.IdentityNumber).Must(BeEven);
        }

        private bool BeEven(string arg)
        {
            return true;
        }
    }
}
