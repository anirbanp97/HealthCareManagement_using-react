using ABC.Pharmacy.Application.DTOs.Medicine;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Validators
{
    public class MedicineValidator
 : AbstractValidator<CreateMedicineDto>
    {

        public MedicineValidator()
        {


            RuleFor(x => x.FullName)
            .NotEmpty();


            RuleFor(x => x.Price)

            .GreaterThan(0);


            RuleFor(x => x.Quantity)

            .GreaterThanOrEqualTo(0);


            RuleFor(x => x.Brand)

            .NotEmpty();


        }


    }
}
