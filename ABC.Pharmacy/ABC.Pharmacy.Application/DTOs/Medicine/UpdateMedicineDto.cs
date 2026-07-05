using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application.DTOs.Medicine
{
    public class UpdateMedicineDto
 : CreateMedicineDto
    {

        public Guid Id { get; set; }

    }
}
