// <copyright file="VehicleRemoved.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RemoveVehicle
{
    using System;
    using MediatR;

    /// <summary>
    /// Vehicle removed notification.
    /// </summary>
    /// <seealso cref="MediatR.INotification" />
    public class VehicleRemoved : INotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleRemoved"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public VehicleRemoved(Guid id)
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
