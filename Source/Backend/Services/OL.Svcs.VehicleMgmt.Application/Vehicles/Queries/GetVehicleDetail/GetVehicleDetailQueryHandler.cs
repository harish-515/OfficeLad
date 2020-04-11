// <copyright file="GetVehicleDetailQueryHandler.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Queries.GetVehicleDetail
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using AutoMapper;
    using MediatR;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;
    using OL.Svcs.VehicleMgmt.Application.Exceptions;
    using OL.Svcs.VehicleMgmt.Domain.Entities;

    /// <summary>
    /// Vehicles list query handler.
    /// </summary>
    /// <seealso cref="IRequestHandler{GetVehiclesListQuery,VehiclesListVm}" />
    public class GetVehicleDetailQueryHandler
        : IRequestHandler<GetVehicleDetailQuery, VehicleLookupDto>
    {
        private readonly IGenericRepository<Vehicle, Guid> vehicleRepository;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVehicleDetailQueryHandler"/> class.
        /// </summary>
        /// <param name="vehicleRepository">The vehicle repository.</param>
        /// <param name="mapper">The mapper.</param>
        public GetVehicleDetailQueryHandler(
            IGenericRepository<Vehicle, Guid> vehicleRepository,
            IMapper mapper)
        {
            this.vehicleRepository = vehicleRepository;
            this.mapper = mapper;
        }

        /// <inheritdoc />
        public async Task<VehicleLookupDto> Handle(
            GetVehicleDetailQuery request, CancellationToken cancellationToken)
        {
            var vehicle = await this.vehicleRepository
                .GetByIdAsync(request.Id).ConfigureAwait(false);

            if (vehicle == null)
            {
                throw new NotFoundException(nameof(vehicle), request.Id);
            }

            return this.mapper.Map<VehicleLookupDto>(vehicle);
        }
    }
}
