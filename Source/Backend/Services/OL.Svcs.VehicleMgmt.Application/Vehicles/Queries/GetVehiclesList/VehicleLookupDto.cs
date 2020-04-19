// <copyright file="VehicleLookupDto.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Vehicles.Queries.GetVehiclesList
{
    using System;
    using AutoMapper;
    using OL.Svcs.VehicleMgmt.Application.Mappings;
    using OL.Svcs.VehicleMgmt.Domain.Entities;

    /// <summary>
    /// Vehicle lookup dto.
    /// </summary>
    /// <seealso cref="IMapFrom{Vehicle}" />
    public class VehicleLookupDto : IMapFrom<Vehicle>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The owner identifier.
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

        /// <inheritdoc />
        public void Mapping(Profile profile)
        {
            if (profile != null)
            {
                _ = profile.CreateMap<Vehicle, VehicleLookupDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Brand, opt => opt.MapFrom(s => s.Brand))
                .ForMember(d => d.Type, opt => opt.MapFrom(s => s.Type))
                .ForMember(d => d.LicenseNumber, opt => opt.MapFrom(s => s.LicenseNumber));
            }
        }
    }
}
