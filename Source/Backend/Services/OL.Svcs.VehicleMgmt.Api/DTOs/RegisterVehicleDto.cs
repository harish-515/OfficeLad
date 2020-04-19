// <copyright file="RegisterVehicleDto.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Api.DTOs
{
    using System;

    /// <summary>
    /// Register vehicle dto.
    /// </summary>
    public class RegisterVehicleDto
    {
        /// <summary>
        /// Gets or sets the license number.
        /// </summary>
        /// <value>
        /// The license number.
        /// </value>
        public string LicenseNumber { get; set; }

        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        /// <value>
        /// The brand.
        /// </value>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the owner identifier.
        /// </summary>
        /// <value>
        /// The owner identifier.
        /// </value>
        public Guid OwnerId { get; set; }
    }
}
