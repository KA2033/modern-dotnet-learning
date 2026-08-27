using ModernDotNet.LoanManagement.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace ModernDotNet.LoanManagement.Application.DependencyInjection
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplication(
        this IServiceCollection services)
        {
            services.AddScoped<ILoanService, LoanService>();

            return services;
        }
    }
}
