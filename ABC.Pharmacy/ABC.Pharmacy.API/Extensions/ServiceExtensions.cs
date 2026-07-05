using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace ABC.Pharmacy.API.Extensions
{
    public static class ServiceExtensions
    {


        public static IServiceCollection
        AddApiServices(
        this IServiceCollection services)
        {


            services.AddControllers();



            services.AddFluentValidationAutoValidation();


            services.AddValidatorsFromAssembly(
            Assembly.Load(
            "ABC.Pharmacy.Application"));



            services.AddEndpointsApiExplorer();



            return services;


        }

    }
}
