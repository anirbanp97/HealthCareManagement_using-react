using ABC.Pharmacy.API.Middlewares;

namespace ABC.Pharmacy.API.Extensions
{
    public static class ApplicationBuilderExtensions
    {

        public static IApplicationBuilder
        UseExceptionMiddleware(
        this IApplicationBuilder app)
        {

            app.UseMiddleware
            <ExceptionMiddleware>();


            return app;

        }

    }
}
