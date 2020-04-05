// <copyright file="GenericRepository.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Persistence
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using OL.Svcs.VehicleMgmt.Application.Abstractions;

    /// <summary>
    /// Implementation of Generic Repository for all entities in domain.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <typeparam name="TEntityId">The type of the entity identifier.</typeparam>
    /// <seealso cref="IGenericRepository{TEntity, TEntityId}" />
    public class GenericRepository<TEntity, TEntityId> : IGenericRepository<TEntity, TEntityId>
       where TEntity : class
    {
        private readonly VehicleManagementDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{TEntity, TEntityId}"/> class.
        /// </summary>
        /// <param name="vehicleManagementDbContext">The vehicle management database context.</param>
        public GenericRepository(VehicleManagementDbContext vehicleManagementDbContext)
        {
            this.context = vehicleManagementDbContext;
        }

        /// <inheritdoc />
        public void Add(TEntity entity)
        {
            this.context.Set<TEntity>().Add(entity);
        }

        /// <inheritdoc />
        public void AddRange(IEnumerable<TEntity> entity)
        {
            this.context.Set<TEntity>().AddRange(entity);
        }

        /// <inheritdoc />
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await this.context.Set<TEntity>().ToListAsync().ConfigureAwait(false);
        }

        /// <inheritdoc />
        public virtual async Task<TEntity> GetByIdAsync(TEntityId id)
        {
            return await this.context.Set<TEntity>().FindAsync(id).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public bool HasChanges()
        {
            return this.context.ChangeTracker.HasChanges();
        }

        /// <inheritdoc />
        public bool Any()
        {
            return this.context.Set<TEntity>().Any();
        }

        /// <inheritdoc />
        public void Remove(TEntity entity)
        {
            this.context.Set<TEntity>().Remove(entity);
        }

        /// <inheritdoc />
        public async Task SaveAsync(CancellationToken cancellationToken)
        {
            await this.context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
