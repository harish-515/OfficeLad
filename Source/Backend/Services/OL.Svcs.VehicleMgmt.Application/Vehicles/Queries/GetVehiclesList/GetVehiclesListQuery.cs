// <copyright file="GetVehiclesListQuery.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Queries.GetVehiclesList
{
    using System.Collections.Generic;
    using MediatR;

    /// <summary>
    /// Vehicles list query.
    /// </summary>
    /// <seealso cref="IRequest{VehiclesListVm}" />
    public class GetVehiclesListQuery : IRequest<IList<VehicleLookupDto>>
    {
    }
}
