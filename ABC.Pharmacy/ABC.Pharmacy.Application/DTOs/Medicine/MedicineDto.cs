using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.DTOs.Medicine
{
    public class MedicineDto
    {

        public Guid Id { get; set; }

        public string FullName { get; set; } = "";

        public string Brand { get; set; } = "";

        public DateTime ExpiryDate { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }


        public bool IsExpiredSoon { get; set; }

        public bool IsLowStock { get; set; }

    }
}
