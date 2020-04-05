// <copyright file="VehicleConfiguration.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Persistence.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using OL.Svcs.VehicleMgmt.Domain.Entities;

    /// <summary>
    /// Vehicle entity configuration.
    /// </summary>
    /// <seealso cref="IEntityTypeConfiguration{Vehicle}" />
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            // Method intentionally left empty.
        }
    }
}
