// <copyright file="VehicleUpdated.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.UpdateVehicle
{
    using System;
    using MediatR;

    /// <summary>
    /// Vehicle updated notification.
    /// </summary>
    /// <seealso cref="MediatR.INotification" />
    public class VehicleUpdated : INotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleUpdated"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public VehicleUpdated(Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; }
    }
}
