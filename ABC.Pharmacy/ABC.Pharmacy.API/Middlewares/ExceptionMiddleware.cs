using ABC.Pharmacy.API.Models;
using System.Net;
using System.Text.Json;

namespace ABC.Pharmacy.API.Middlewares
{
    public class ExceptionMiddleware
    {

        private readonly RequestDelegate _next;


        public ExceptionMiddleware(
            RequestDelegate next)
        {
            _next = next;
        }



        public async Task InvokeAsync(
            HttpContext context)
        {

            try
            {

                await _next(context);

            }
            catch (Exception ex)
            {

                context.Response.ContentType =
                    "application/json";


                context.Response.StatusCode =
                    (int)HttpStatusCode.InternalServerError;



                var response =
                new ErrorResponse
                {
                    StatusCode =
                    context.Response.StatusCode,


                    Message =
                    ex.Message
                };



                await context.Response
                .WriteAsync(
                    JsonSerializer.Serialize(response));

            }

        }

    }
}
