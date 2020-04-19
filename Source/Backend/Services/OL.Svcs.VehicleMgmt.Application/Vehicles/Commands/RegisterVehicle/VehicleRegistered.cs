// <copyright file="VehicleRegistered.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RegisterVehicle
{
    using System;
    using MediatR;

    /// <summary>
    /// Vehicle registered notification.
    /// </summary>
    /// <seealso cref="MediatR.INotification" />
    public class VehicleRegistered : INotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleRegistered"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public VehicleRegistered(Guid id)
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
