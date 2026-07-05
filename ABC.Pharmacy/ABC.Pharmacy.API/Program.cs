//using ABC.Pharmacy.API.Extensions;
//using ABC.Pharmacy.Infrastructure;


//var builder = WebApplication.CreateBuilder(args);


//// ======================================
//// Register Services (Before Build)
//// ======================================


//// Controllers + Swagger + Validation
//builder.Services.AddApiServices();


//// Infrastructure Dependency Injection
//// Repository, JSON Context, JWT Service
//builder.Services.AddInfrastructure();
//builder.Services.AddApplication();

//// JWT Authentication
//builder.Services.AddJwtAuthentication(
//    builder.Configuration);


//// ======================================
//// Build Application
//// ======================================


//var app = builder.Build();


//// ======================================
//// Middleware Pipeline
//// ======================================


//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();

//    app.UseSwaggerUI();
//}


//// Global Exception Middleware

//app.UseExceptionMiddleware();


//// HTTPS

//app.UseHttpsRedirection();


//// Authentication MUST come before Authorization

//app.UseAuthentication();


//app.UseAuthorization();


//// Controllers Endpoint

//app.MapControllers();


//// Run Application

//app.Run();

using ABC.Pharmacy.API.Extensions;
using ABC.Pharmacy.Application;
using ABC.Pharmacy.Infrastructure;


var builder = WebApplication.CreateBuilder(args);


// ======================================
// Service Registration
// Before builder.Build()
// ======================================


// API Layer
// Controllers, Swagger, Validation
builder.Services.AddApiServices();


// Application Layer
// Services (AuthService, MedicineService, SaleService)
builder.Services.AddApplication();


// Infrastructure Layer
// Repository, JsonDbContext, JWT Service
builder.Services.AddInfrastructure();


// JWT Authentication + Swagger JWT
builder.Services.AddJwtAuthentication(
    builder.Configuration);


// ======================================
// Build Application
// ======================================
builder.Services.AddCors(options =>
{

    options.AddPolicy("React",
        policy =>
        {
            policy
            .WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });

});

var app = builder.Build();



// ======================================
// Middleware Pipeline
// After Build
// ======================================


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();

    app.UseSwaggerUI();
}


// Global Exception Handler
app.UseExceptionMiddleware();


// HTTPS Middleware
app.UseHttpsRedirection();


// Authentication always before Authorization
app.UseAuthentication();


app.UseAuthorization();


// Map API Controllers
app.MapControllers();


// Run Application
app.Run();