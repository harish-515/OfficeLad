// <copyright file="SeedSampleDataCommandHandler.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Miscellaneous.SeedSampleData
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;
    using OL.Svcs.VehicleMgmt.Domain.Entities;

    /// <summary>
    /// Seed sample data command handler.
    /// </summary>
    /// <seealso cref="IRequestHandler{SeedSampleDataCommand}" />
    public class SeedSampleDataCommandHandler : IRequestHandler<SeedSampleDataCommand>
    {
        private readonly IGenericRepository<Vehicle, Guid> vehicleRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="SeedSampleDataCommandHandler"/> class.
        /// </summary>
        /// <param name="vehicleRepository">The vehicle repository.</param>
        public SeedSampleDataCommandHandler(IGenericRepository<Vehicle, Guid> vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;
        }

        /// <summary>
        /// Handles the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>unit value.</returns>
        public async Task<Unit> Handle(SeedSampleDataCommand request, CancellationToken cancellationToken)
        {
            var seeder = new SampleDataSeeder(this.vehicleRepository);

            await seeder.SeedAllAsync(cancellationToken).ConfigureAwait(false);

            return Unit.Value;
        }
    }
}
