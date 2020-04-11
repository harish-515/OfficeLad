// <copyright file="RemoveVehicleCommandHandler.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RemoveVehicle
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using MediatR;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;
    using OL.Svcs.VehicleMgmt.Domain.Entities;

    /// <summary>
    /// Remove vehicle command handler.
    /// </summary>
    /// <seealso cref="IRequestHandler{RegisterVehicleCommand}" />
    public class RemoveVehicleCommandHandler : IRequestHandler<RemoveVehicleCommand>
    {
        private readonly IGenericRepository<Vehicle, Guid> vehicleRepository;
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveVehicleCommandHandler" /> class.
        /// </summary>
        /// <param name="vehicleRepository">The vehicle repository.</param>
        /// <param name="mediator">The mediator.</param>
        public RemoveVehicleCommandHandler(
                    IGenericRepository<Vehicle, Guid> vehicleRepository,
                    IMediator mediator)
        {
            this.vehicleRepository = vehicleRepository;
            this.mediator = mediator;
        }

        /// <inheritdoc />
        public async Task<Unit> Handle(
            RemoveVehicleCommand request,
            CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var entity = new Vehicle(request.Id);

                this.vehicleRepository.Remove(entity);

                await this.vehicleRepository.SaveAsync(
                    cancellationToken).ConfigureAwait(false);

                await this.mediator.Publish(
                    new VehicleRemoved(entity.Id), cancellationToken).ConfigureAwait(false);
            }

            return Unit.Value;
        }
    }
}
