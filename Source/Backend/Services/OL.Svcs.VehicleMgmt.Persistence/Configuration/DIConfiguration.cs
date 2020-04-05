// <copyright file="DIConfiguration.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Persistence.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;

    /// <summary>
    /// Dependency Injection Configuration class.
    /// </summary>
    public static class DIConfiguration
    {
        /// <summary>
        /// Configure dependency injection in persistence layer.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        /// <returns>Service Collection.</returns>
        public static IServiceCollection AddPersistence(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VehicleManagementDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("VehicleManagementDatabase")));

            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));

            return services;
        }
    }
}
