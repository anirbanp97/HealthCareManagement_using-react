using ABC.Pharmacy.Application.Interfaces.Repositories;
using ABC.Pharmacy.Application.Interfaces.Services;
using ABC.Pharmacy.Infrastructure.Persistence;
using ABC.Pharmacy.Infrastructure.Repositories;
using ABC.Pharmacy.Infrastructure.Security;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Pharmacy.Infrastructure
{
    public static class DependencyInjection
    {


        public static IServiceCollection
            AddInfrastructure(
            this IServiceCollection services)
        {


            // JSON Context

            services.AddSingleton<JsonDbContext>();



            // Repositories

            services.AddScoped
            <IUserRepository,
            UserRepository>();



            services.AddScoped
            <IMedicineRepository,
            MedicineRepository>();



            services.AddScoped
            <ISaleRepository,
            SaleRepository>();




            // Security


            services.AddScoped
            <IJwtService,
            JwtService>();



            services.AddScoped
            <PasswordHasher>();



            return services;


        }


    }
}
