// <copyright file="DIConfiguration.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Configuration
{
    using System.Reflection;
    using AutoMapper;
    using FluentValidation;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;
    using OL.Svcs.VehicleMgmt.Application.Behaviours;

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
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(
                typeof(IPipelineBehavior<,>),
                typeof(RequestPerformanceBehaviour<,>));
            services.AddTransient(
                typeof(IPipelineBehavior<,>),
                typeof(RequestValidationBehaviour<,>));
            return services;
        }
    }
}
