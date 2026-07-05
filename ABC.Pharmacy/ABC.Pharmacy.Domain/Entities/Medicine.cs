using ABC.Pharmacy.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Domain.Entities
{
    public class Medicine : BaseEntity
    {


        public string FullName { get; set; }
            = string.Empty;



        public string Notes { get; set; }
            = string.Empty;



        public DateTime ExpiryDate { get; set; }



        public int Quantity { get; set; }



        public decimal Price { get; set; }



        public string Brand { get; set; }
            = string.Empty;




        public bool IsExpiredSoon()
        {
            return ExpiryDate <= DateTime.UtcNow.AddDays(30);
        }



        public bool IsLowStock()
        {
            return Quantity < 10;
        }

    }
}
