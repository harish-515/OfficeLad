// <copyright file="DIConfiguration.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Infrastructure.Configuration
{
    using Microsoft.Extensions.DependencyInjection;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;
    using OL.Svcs.VehicleMgmt.Infrastructure.Services;

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
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services)
        {
            services.AddTransient<INotificationService, NotificationService>();
            return services;
        }
    }
}
