// <copyright file="Vehicle.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OfficeLad.Services.VehicleManagement.Domain.Entities
{
    using System;

    /// <summary>
    /// Vehicle entity.
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }

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
