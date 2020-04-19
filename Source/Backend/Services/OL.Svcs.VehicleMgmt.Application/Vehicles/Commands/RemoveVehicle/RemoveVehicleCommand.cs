// <copyright file="RemoveVehicleCommand.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RemoveVehicle
{
    using System;
    using MediatR;

    /// <summary>
    /// Update vehicle command class.
    /// </summary>
    /// <seealso cref="MediatR.IRequest" />
    public class RemoveVehicleCommand : IRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveVehicleCommand"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public RemoveVehicleCommand(
            Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Gets identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; }
    }
}
