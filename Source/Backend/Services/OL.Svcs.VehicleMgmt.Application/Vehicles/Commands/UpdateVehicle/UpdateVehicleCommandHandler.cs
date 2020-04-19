// <copyright file="UpdateVehicleCommandHandler.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.UpdateVehicle
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;
    using OL.Svcs.VehicleMgmt.Application.Exceptions;
    using OL.Svcs.VehicleMgmt.Domain.Entities;

    /// <summary>
    /// Register vehicle command handler.
    /// </summary>
    /// <seealso cref="IRequestHandler{UpdateVehicleCommand}" />
    public class UpdateVehicleCommandHandler : IRequestHandler<UpdateVehicleCommand>
    {
        private readonly IGenericRepository<Vehicle, Guid> vehicleRepository;
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVehicleCommandHandler" /> class.
        /// </summary>
        /// <param name="vehicleRepository">The vehicle repository.</param>
        /// <param name="mediator">The mediator.</param>
        public UpdateVehicleCommandHandler(
                    IGenericRepository<Vehicle, Guid> vehicleRepository,
                    IMediator mediator)
        {
            this.vehicleRepository = vehicleRepository;
            this.mediator = mediator;
        }

        /// <inheritdoc />
        public async Task<Unit> Handle(
            UpdateVehicleCommand request,
            CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var entity = await this.vehicleRepository.GetByIdAsync(
                    request.Id).ConfigureAwait(false);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(Vehicle), request.Id);
                }

                entity.Brand = request.Brand;
                entity.LicenseNumber = request.LicenseNumber;
                entity.Type = request.Type;

                await this.vehicleRepository.SaveAsync(
                    cancellationToken).ConfigureAwait(false);

                await this.mediator.Publish(
                    new VehicleUpdated(entity.Id), cancellationToken).ConfigureAwait(false);
            }

            return Unit.Value;
        }
    }
}
