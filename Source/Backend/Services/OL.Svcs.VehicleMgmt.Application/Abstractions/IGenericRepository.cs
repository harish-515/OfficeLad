// <copyright file="IGenericRepository.cs" company="DevTutors">
// Copyright (c) DevTutors. All rights reserved.
// </copyright>

namespace OL.Svcs.VehicleMgmt.Application.Abstractions
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Generic repository for all entities in domain.
    /// </summary>
    /// <typeparam name="TEntity">Entity type.</typeparam>
    /// <typeparam name="TEntityId">Entity Id type.</typeparam>
    public interface IGenericRepository<TEntity, TEntityId>
    {
        /// <summary>
        /// Gets an entity asynchronously with provided id.
        /// </summary>
        /// <param name="id">The entity id.</param>
        /// <returns>The entity.</returns>
        Task<TEntity> GetByIdAsync(TEntityId id);

        /// <summary>
        /// Gets all entities asynchronously.
        /// </summary>
        /// <returns>All Entities.</returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Checks if the table contains an entity.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the table has entities; otherwise, <c>false</c>.
        /// </returns>
        bool Any();

        /// <summary>
        /// Saves the Entity modified entity.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// Task object.
        /// </returns>
        Task SaveAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Determines whether the entity has changes.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the entity has changes; otherwise, <c>false</c>.
        /// </returns>
        bool HasChanges();

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Adds the list of entities.
        /// </summary>
        /// <param name="entity">List of entities.</param>
        void AddRange(IEnumerable<TEntity> entity);

        /// <summary>
        /// Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Remove(TEntity entity);
    }
}
