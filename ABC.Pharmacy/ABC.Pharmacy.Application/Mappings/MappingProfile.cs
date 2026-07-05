using ABC.Pharmacy.Application.DTOs.Medicine;
using ABC.Pharmacy.Application.DTOs.Sale;
using ABC.Pharmacy.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ABC.Pharmacy.Application.Mappings
{
    public class MappingProfile : Profile
    {


        public MappingProfile()
        {


            CreateMap<Medicine, MedicineDto>();


            CreateMap<Sale, SaleDto>();


        }

    }
}
