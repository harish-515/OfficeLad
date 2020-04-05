// <copyright file="SampleDataSeeder.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OfficeLad.Services.VehicleManagement.Application.Miscellaneous.SeedSampleData
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using OfficeLad.Services.VehicleManagement.Application.Abstractions;
    using OfficeLad.Services.VehicleManagement.Domain.Entities;

    /// <summary>
    /// Sample Data Seeder class.
    /// </summary>
    public class SampleDataSeeder
    {
        private readonly IGenericRepository<Vehicle, Guid> vehicleRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleDataSeeder"/> class.
        /// </summary>
        /// <param name="vehicleRepository">The vehicle repository.</param>
        public SampleDataSeeder(IGenericRepository<Vehicle, Guid> vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }

        /// <summary>
        /// Seeds all entities asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task object.</returns>
        public async Task SeedAllAsync(CancellationToken cancellationToken)
        {
            if (this.vehicleRepository.Any())
            {
                return;
            }

            await this.SeedVehiclesAsync(cancellationToken).ConfigureAwait(false);
        }

        private async Task SeedVehiclesAsync(CancellationToken cancellationToken)
        {
            var vehicles = new List<Vehicle>()
            {
                new Vehicle
                {
                    Id = default, LicenseNumber = "TS08GG1111",
                    Brand = "Maruti", Type = "Car", OwnerId = default,
                },
                new Vehicle
                {
                    Id = default, LicenseNumber = "TS08GG1112",
                    Brand = "Maruti", Type = "Car", OwnerId = default,
                },
                new Vehicle
                {
                    Id = default, LicenseNumber = "TS08GG1113",
                    Brand = "Maruti", Type = "Car", OwnerId = default,
                },
                new Vehicle
                {
                    Id = default, LicenseNumber = "TS08GG1114",
                    Brand = "Maruti", Type = "Car", OwnerId = default,
                },
                new Vehicle
                {
                    Id = default, LicenseNumber = "TS08GG1115",
                    Brand = "Maruti", Type = "Car", OwnerId = default,
                },
            };

            this.vehicleRepository.AddRange(vehicles);

            await this.vehicleRepository.SaveAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
