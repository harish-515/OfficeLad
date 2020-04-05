// <copyright file="VehicleManagementDbContext.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OfficeLad.Services.VehicleManagement.Persistence
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using OfficeLad.Services.VehicleManagement.Domain.Entities;

    /// <summary>
    /// Vehicle Management Database context.
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class VehicleManagementDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleManagementDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public VehicleManagementDbContext(
            DbContextOptions<VehicleManagementDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the vehicles.
        /// </summary>
        /// <value>
        /// The vehicles DbSet.
        /// </value>
        public DbSet<Vehicle> Vehicles { get; set; }

        /// <inheritdoc />
        public override Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }
            else
            {
                _ = modelBuilder.ApplyConfigurationsFromAssembly(
                    typeof(VehicleManagementDbContext).Assembly);
            }
        }
    }
}
