// <copyright file="UpdateVehicleCommand.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.UpdateVehicle
{
    using System;
    using MediatR;

    /// <summary>
    /// Update vehicle command class.
    /// </summary>
    /// <seealso cref="MediatR.IRequest" />
    public class UpdateVehicleCommand : IRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVehicleCommand" /> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="licenseNumber">The license number.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="type">The type.</param>
        /// <param name="ownerId">The owner identifier.</param>
        public UpdateVehicleCommand(
            Guid id,
            string licenseNumber,
            string brand,
            string type,
            Guid ownerId)
        {
            this.Id = id;
            this.LicenseNumber = licenseNumber;
            this.Brand = brand;
            this.Type = type;
            this.OwnerId = ownerId;
        }

        /// <summary>
        /// Gets identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; }

        /// <summary>
        /// Gets the license number.
        /// </summary>
        /// <value>
        /// The license number.
        /// </value>
        public string LicenseNumber { get; }

        /// <summary>
        /// Gets the brand.
        /// </summary>
        /// <value>
        /// The brand.
        /// </value>
        public string Brand { get; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; }

        /// <summary>
        /// Gets the owner identifier.
        /// </summary>
        /// <value>
        /// The owner identifier.
        /// </value>
        public Guid OwnerId { get; }
    }
}
