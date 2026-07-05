using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.DTOs.Sale
{
    public class SaleDto
    {

        public Guid Id { get; set; }

        public Guid MedicineId { get; set; }

        public int QuantitySold { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime SaleDate { get; set; }

    }
}
