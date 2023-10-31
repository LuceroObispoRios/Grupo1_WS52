using CargaSinEstres.API.CargaSinEstres.Domain.Repositories;
using CargaSinEstres.API.CargaSinEstres.Domain.Services;
using CargaSinEstres.API.CargaSinEstres.Mapping;
using CargaSinEstres.API.CargaSinEstres.Security.Authorization.Handlers.Implementations;
using CargaSinEstres.API.CargaSinEstres.Security.Authorization.Handlers.Interfaces;
using CargaSinEstres.API.CargaSinEstres.Security.Authorization.Middleware;
using CargaSinEstres.API.CargaSinEstres.Security.Authorization.Settings;
using CargaSinEstres.API.CargaSinEstres.Services;
using CargaSinEstres.API.CargaSinEstres.Shared.Persistence.Contexts;
using CargaSinEstres.API.CargaSinEstres.Shared.Persistence.Repositories;
using CargaSinEstres.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using CompanyRepository = CargaSinEstres.API.CargaSinEstres.Security.Persistence.Repositories.CompanyRepository;
using CompanyService = CargaSinEstres.API.CargaSinEstres.Security.Services.CompanyService;
using ICompanyRepository = CargaSinEstres.API.CargaSinEstres.Security.Domain.Repositories.ICompanyRepository;
using ICompanyService = CargaSinEstres.API.CargaSinEstres.Security.Domain.Services.ICompanyService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add database connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySQL(connectionString)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());

//add lowercase routes
builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Shared Injection Configuration
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// AppSettings Configuration
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

// Dependency Injection Configuration
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IReviewService, ReviewService>();

// Security Injection Configuration
builder.Services.AddScoped<IJwtHandler, JwtHandler>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
builder.Services.AddScoped<ICompanyService, CompanyService>();

// AutoMapper Configuration
builder.Services.AddAutoMapper(typeof(ModelToResourceProfile), 
    typeof(ResourceToModelProfile),
    typeof(CargaSinEstres.API.CargaSinEstres.Security.Mapping.ModelToResourceProfile),
    typeof(CargaSinEstres.API.CargaSinEstres.Security.Mapping.ResourceToModelProfile)
    );
var app = builder.Build();

//validation for ensuring Database Objects are created
using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<AppDbContext>())
{
    context.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure Error Handler Middleware

app.UseMiddleware<ErrorHandlerMiddleware>();

// Configure JWT Handling

app.UseMiddleware<JwtMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();