using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ModernDotNet.LoanManagement.Application.Repositories;
using ModernDotNet.LoanManagement.Infrastructure.Data;
using ModernDotNet.LoanManagement.Infrastructure.Repositories;

namespace ModernDotNet.LoanManagement.Infrastructure.DependencyInjection
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<LoanDbContext>(options =>options.UseSqlServer(
            configuration.GetConnectionString("LoanDb")));

            services.AddScoped<ILoanRepository, LoanRepository>();
            return services;
        }
    }
}
