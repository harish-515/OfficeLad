// <copyright file="RegisterVehicleCommand.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Commands.RegisterVehicle
{
    using System;
    using MediatR;

    /// <summary>
    /// Register vehicle command class.
    /// </summary>
    /// <seealso cref="MediatR.IRequest" />
    public class RegisterVehicleCommand : IRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterVehicleCommand"/> class.
        /// </summary>
        /// <param name="licenseNumber">The license number.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="type">The type.</param>
        /// <param name="ownerId">The owner identifier.</param>
        public RegisterVehicleCommand(
            string licenseNumber,
            string brand,
            string type,
            Guid ownerId)
        {
            this.LicenseNumber = licenseNumber;
            this.Brand = brand;
            this.Type = type;
            this.OwnerId = ownerId;
        }

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
