using ABC.Pharmacy.Application.Interfaces.Services;
using ABC.Pharmacy.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Application
{
    public static class DependencyInjection
    {


        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {


            services.AddScoped
            <IAuthService, AuthService>();


            services.AddScoped
            <IMedicineService, MedicineService>();


            services.AddScoped
            <ISaleService, SaleService>();


            return services;

        }

    }
}
