using ModernDotNet.LoanManagement.Api.Repositories;
using ModernDotNet.LoanManagement.Api.Services;
using Microsoft.EntityFrameworkCore;
using ModernDotNet.LoanManagement.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<ILoanService, LoanService>();
builder.Services.AddScoped<ILoanRepository, LoanRepository>();

builder.Services.AddDbContext<LoanDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("LoanDb")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
