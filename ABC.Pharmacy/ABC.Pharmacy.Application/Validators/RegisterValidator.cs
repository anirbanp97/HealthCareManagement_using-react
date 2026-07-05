using ABC.Pharmacy.Application.DTOs.Auth;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Validators
{
    public class RegisterValidator
: AbstractValidator<RegisterRequestDto>
    {


        public RegisterValidator()
        {

            RuleFor(x => x.FullName)
            .NotEmpty();



            RuleFor(x => x.Email)

            .EmailAddress()

            .NotEmpty();



            RuleFor(x => x.Password)

            .MinimumLength(6);


        }

    }
}
