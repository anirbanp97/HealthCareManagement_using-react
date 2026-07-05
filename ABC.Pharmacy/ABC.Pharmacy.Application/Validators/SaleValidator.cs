using ABC.Pharmacy.Application.DTOs.Sale;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.Validators
{
    public class SaleValidator
 : AbstractValidator<CreateSaleDto>
    {


        public SaleValidator()
        {


            RuleFor(x => x.MedicineId)

            .NotEmpty();



            RuleFor(x => x.QuantitySold)

            .GreaterThan(0);


        }

    }
}
