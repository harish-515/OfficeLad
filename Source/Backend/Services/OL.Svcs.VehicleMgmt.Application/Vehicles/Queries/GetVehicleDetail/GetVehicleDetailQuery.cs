// <copyright file="GetVehicleDetailQuery.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Queries.GetVehicleDetail
{
    using System;
    using MediatR;

    /// <summary>
    /// Get vehicle detail query.
    /// </summary>
    /// <seealso cref="IRequest{VehicleLookupDto}" />
    public class GetVehicleDetailQuery : IRequest<VehicleLookupDto>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id { get; set; }
    }
}
