using ModernDotNet.LoanManagement.Infrastructure.Repositories;
using ModernDotNet.LoanManagement.Application.Repositories;
using ModernDotNet.LoanManagement.Application.Services;
using Microsoft.EntityFrameworkCore;
using ModernDotNet.LoanManagement.Infrastructure.Data;
using ModernDotNet.LoanManagement.Application.DependencyInjection;
using ModernDotNet.LoanManagement.Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();
/*builder.Services.AddScoped<ILoanService, LoanService>();
builder.Services.AddScoped<ILoanRepository, LoanRepository>();

builder.Services.AddDbContext<LoanDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("LoanDb")));*/
builder.Services.AddApplication();

builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
