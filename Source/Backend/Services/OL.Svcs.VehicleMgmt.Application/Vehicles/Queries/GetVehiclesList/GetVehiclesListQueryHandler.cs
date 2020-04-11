// <copyright file="GetVehiclesListQueryHandler.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Queries.GetVehiclesList
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using MediatR;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;
    using OL.Svcs.VehicleMgmt.Domain.Entities;

    /// <summary>
    /// Vehicles list query handler.
    /// </summary>
    /// <seealso cref="IRequestHandler{GetVehiclesListQuery,VehiclesListVm}" />
    public class GetVehiclesListQueryHandler
        : IRequestHandler<GetVehiclesListQuery, IList<VehicleLookupDto>>
    {
        private readonly IGenericRepository<Vehicle, Guid> vehicleRepository;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVehiclesListQueryHandler"/> class.
        /// </summary>
        /// <param name="vehicleRepository">The vehicle repository.</param>
        /// <param name="mapper">The mapper.</param>
        public GetVehiclesListQueryHandler(
            IGenericRepository<Vehicle, Guid> vehicleRepository,
            IMapper mapper)
        {
            this.vehicleRepository = vehicleRepository;
            this.mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<IList<VehicleLookupDto>> Handle(
            GetVehiclesListQuery request, CancellationToken cancellationToken)
        {
            var vehicles = await this.vehicleRepository.GetAllAsync()
                .ConfigureAwait(false);

            return this.mapper.Map<IEnumerable<Vehicle>, IList<VehicleLookupDto>>(
                vehicles);
        }
    }
}
