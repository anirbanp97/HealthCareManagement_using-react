using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.DTOs.Sale
{
    public class CreateSaleDto
    {

        public Guid MedicineId { get; set; }

        public int QuantitySold { get; set; }

    }
}
