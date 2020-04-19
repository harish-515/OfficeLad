// <copyright file="RegisterVehicleCommandHandler.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RegisterVehicle
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;
    using OL.Svcs.VehicleMgmt.Domain.Entities;

    /// <summary>
    /// Register vehicle command handler.
    /// </summary>
    /// <seealso cref="IRequestHandler{RegisterVehicleCommand}" />
    public class RegisterVehicleCommandHandler : IRequestHandler<RegisterVehicleCommand>
    {
        private readonly IGenericRepository<Vehicle, Guid> vehicleRepository;
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterVehicleCommandHandler" /> class.
        /// </summary>
        /// <param name="vehicleRepository">The vehicle repository.</param>
        /// <param name="mediator">The mediator.</param>
        public RegisterVehicleCommandHandler(
                    IGenericRepository<Vehicle, Guid> vehicleRepository,
                    IMediator mediator)
        {
            this.vehicleRepository = vehicleRepository;
            this.mediator = mediator;
        }

        /// <inheritdoc />
        public async Task<Unit> Handle(
            RegisterVehicleCommand request,
            CancellationToken cancellationToken)
        {
            var entity = new Vehicle(Guid.NewGuid());
            entity.Brand = request?.Brand;
            entity.LicenseNumber = request?.LicenseNumber;
            entity.Type = request?.Type;

            this.vehicleRepository.Add(entity);

            await this.vehicleRepository.SaveAsync(
                cancellationToken).ConfigureAwait(false);

            await this.mediator.Publish(
                new VehicleRegistered(entity.Id), cancellationToken).ConfigureAwait(false);

            return Unit.Value;
        }
    }
}
