// <copyright file="Vehicle.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OfficeLad.Services.VehicleManagement.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Centaurus.Domain;

    /// <summary>
    /// Vehicle Entity.
    /// </summary>
    /// <seealso cref="Entity{Guid}" />
    internal class Vehicle : Entity<Guid>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class.
        /// </summary>
        /// <param name="id">The value of the entity key.</param>
        public Vehicle(Guid id)
            : base(id)
        {

        }
    }
}
