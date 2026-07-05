using ABC.Pharmacy.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Domain.Entities
{
    public class Sale : BaseEntity
    {


        public Guid MedicineId { get; set; }



        public int QuantitySold { get; set; }



        public decimal UnitPrice { get; set; }



        public decimal TotalPrice
        {
            get
            {
                return QuantitySold * UnitPrice;
            }
        }



        public DateTime SaleDate { get; set; }


        public Sale()
        {
            SaleDate = DateTime.UtcNow;
        }

    }
}
