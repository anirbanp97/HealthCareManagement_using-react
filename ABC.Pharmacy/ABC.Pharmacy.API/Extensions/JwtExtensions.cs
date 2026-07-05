using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace ABC.Pharmacy.API.Extensions
{
    public static class JwtExtensions
    {


        public static IServiceCollection AddJwtAuthentication(
            this IServiceCollection services,
            IConfiguration configuration)
        {


            // ==========================
            // JWT Authentication
            // ==========================


            services.AddAuthentication(
                JwtBearerDefaults.AuthenticationScheme
            )
            .AddJwtBearer(options =>
            {

                options.TokenValidationParameters =
                    new TokenValidationParameters
                    {

                        ValidateIssuer = true,


                        ValidateAudience = true,


                        ValidateLifetime = true,


                        ValidateIssuerSigningKey = true,


                        ValidIssuer =
                            configuration["Jwt:Issuer"],


                        ValidAudience =
                            configuration["Jwt:Audience"],


                        IssuerSigningKey =
                            new SymmetricSecurityKey(
                                Encoding.UTF8.GetBytes(
                                    configuration["Jwt:Key"]!
                                )
                            )

                    };

            });





            // ==========================
            // Swagger JWT Configuration
            // ==========================


            services.AddSwaggerGen(options =>
            {


                options.AddSecurityDefinition(
                    "Bearer",
                    new OpenApiSecurityScheme
                    {

                        Description =
                        "JWT Authorization header. Enter only your token.",


                        Name = "Authorization",


                        In = ParameterLocation.Header,


                        Type = SecuritySchemeType.Http,


                        Scheme = "Bearer",


                        BearerFormat = "JWT"

                    });



                options.AddSecurityRequirement(
                    new OpenApiSecurityRequirement
                    {

                        {
                            new OpenApiSecurityScheme
                            {

                                Reference =
                                new OpenApiReference
                                {

                                    Type =
                                    ReferenceType.SecurityScheme,


                                    Id = "Bearer"

                                }

                            },

                            Array.Empty<string>()

                        }

                    });


            });



            return services;


        }


    }
}
