using ABC.Pharmacy.Application.DTOs.Auth;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Validators
{
    public class LoginValidator
: AbstractValidator<LoginRequestDto>
    {

        public LoginValidator()
        {


            RuleFor(x => x.Email)

            .NotEmpty()

            .EmailAddress();



            RuleFor(x => x.Password)

            .NotEmpty();


        }


    }
}
