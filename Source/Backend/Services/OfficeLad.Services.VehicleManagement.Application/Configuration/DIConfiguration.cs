// <copyright file="DIConfiguration.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OfficeLad.Services.VehicleManagement.Application.Configuration
{
    using System.Reflection;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Dependency Injection Configuration class.
    /// </summary>
    public static class DIConfiguration
    {
        /// <summary>
        /// Configure dependency injection in application layer.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns>Service Collection.</returns>
        public static IServiceCollection AddApplication(
            this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
